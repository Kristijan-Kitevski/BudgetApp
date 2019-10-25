using AutoMapper;
using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using BudgetApp.Services.Interface;
using BudgetAppWebModels.Enums;
using BudgetAppWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BudgetApp.Services.Services
{
    public class IncomeService : IIncomeService
    {
      
        private readonly IRepository<Income> _incomeRepository;
        private readonly IMapper _mapper;

        public IncomeService(IRepository<Income> incomeRepository, IMapper mapper)
        {
           
            _incomeRepository = incomeRepository;
            _mapper = mapper;
        }

        public IEnumerable<IncomeViewModel> GetAllIncomes()
        {
            return _mapper.Map<IEnumerable<IncomeViewModel>>(
                _incomeRepository.GetAll()
            );
        }

        public IEnumerable<IncomeViewModel> GetIncomes(SortBy sortBy, IEnumerable<Filter> filters)
        {
            var incomes = _incomeRepository.GetAll();
            return _mapper.Map<IEnumerable<IncomeViewModel>>(
                FilterIncomes(incomes, filters)
            );
        }

        public IncomeViewModel GetIncome(int id)
        {
            return _mapper.Map<IncomeViewModel>(
                _incomeRepository.GetById(id)
            );
        }

        public void CreateIncome(IncomeViewModel income)
        {
            _incomeRepository.Insert(
                _mapper.Map<Income>(income)
            );
        }

        public void EditIncome(IncomeViewModel income)
        {
            _incomeRepository.Update(
                _mapper.Map<Income>(income)
            );
        }

        public void DeleteIncome(int id)
        {
            _incomeRepository.Delete(id);
        }

        private IEnumerable<Income> FilterIncomes(IEnumerable<Income> incomes, IEnumerable<Filter> filters)
        {
            IEnumerable<Income> incomesFiltered = incomes;

            foreach (Filter filter in filters)
            {
                switch (filter.FilterBy)
                {
                    case FilterBy.Date:
                        incomesFiltered = incomesFiltered.Where(i => 
                            IsStartDateValid(i.Date, filter.Values.StartDate) &&
                            IsEndDateValid(i.Date, filter.Values.EndDate)
                        );
                        break;
                    case FilterBy.Type:
                        incomesFiltered = incomesFiltered.Where(i =>
                            i.IncomeType == filter.Values.Type
                        );
                        break;
                    case FilterBy.Value:
                        incomesFiltered = incomesFiltered.Where(i =>
                            IsValueValid(i.IncomeValue, filter.Values.ValueFrom, filter.Values.ValueTo)
                        );
                        break;
                    default:
                        break;
                }
            }

            return incomesFiltered;
        }

        private bool IsValueValid(double incomeValue, double valueFrom, double valueTo)
        {
            if (incomeValue >= valueFrom && incomeValue < valueTo)
                return true;
            else
                return false;
        }

        private bool IsStartDateValid(DateTime incomeDate, DateTime startDate)
        {
            int result = incomeDate.CompareTo(startDate);

            if (result == -1)
                return false;
            else if (result == 0 || result == 1)
                return true;
            else
                return false;
        }

        private bool IsEndDateValid(DateTime incomeDate, DateTime endDate)
        {
            int result = incomeDate.CompareTo(endDate);

            if (result == -1 || result == 0)
                return true;
            else
                return false;
        }
    }
}
