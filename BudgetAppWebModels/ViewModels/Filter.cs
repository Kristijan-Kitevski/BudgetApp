using BudgetAppWebModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetAppWebModels.ViewModels
{
    public class Filter
    {
        public FilterBy FilterBy { get; set; }
        public dynamic Values { get; set; }
    }
}
