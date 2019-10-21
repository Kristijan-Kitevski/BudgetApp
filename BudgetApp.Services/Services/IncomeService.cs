using BudgetApp.DataAccess.Interfaces;
using BudgetApp.Domain.Models;
using BudgetApp.Services.Interface;
using BudgetAppWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Services.Services
{
    public class IncomeService : IIncomeServices
    {
        private readonly IRepository<Income> _incomeRepository;
        private readonly IUserRepository _userRepository;

        public IncomeService(IRepository<Income> incomeRepository,IUserRepository userRepository)
        {
            _incomeRepository = incomeRepository;
            _userRepository = userRepository;
        }

        public int CreateIncome(IncomeViewModel income, string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IncomeViewModel> GetAllIncomes()
        {
            throw new NotImplementedException();
        }

        public IncomeViewModel GetIncomeByPeriod(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public int RemoveIncome(int incomeId)
        {
            throw new NotImplementedException();
        }

        public int UpdateIncome(int incomeId, Enum IncomeTypeViewModel, DateTime incomeDate, double incomeValue)
        {
            throw new NotImplementedException();
        }
    }
}
