using AutoMapper;
using BudgetApp.Domain.Models;
using BudgetAppWebModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Services.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Income, IncomeViewModel>()
                .ReverseMap();

            CreateMap<Expense, ExpenseViewModel>()
                .ReverseMap();

            CreateMap<User, UserViewModel>();

            CreateMap<RegisterViewModel, User>()
                .ForMember(dest => dest.FullName, src => src.ResolveUsing(rm => $"{rm.FirstName} {rm.LastName}"));
        }
    }
}
