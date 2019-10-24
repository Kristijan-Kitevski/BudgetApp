#pragma checksum "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ed7c8222dd85cc4bb09d949d008f2170fe4c007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Budget_Index), @"mvc.1.0.view", @"/Views/Budget/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Budget/Index.cshtml", typeof(AspNetCore.Views_Budget_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\_ViewImports.cshtml"
using BudgetApp;

#line default
#line hidden
#line 2 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\_ViewImports.cshtml"
using BudgetAppWebModels.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ed7c8222dd85cc4bb09d949d008f2170fe4c007", @"/Views/Budget/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc7d5a23ff554bbd5c5b6ebec20fb79ec4442320", @"/Views/_ViewImports.cshtml")]
    public class Views_Budget_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BudgetViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
  
    ViewData["Title"] = "Budget";

    var budgetValue = Model.IncomeSum - Model.ExpenseSum;

#line default
#line hidden
            BeginContext(129, 358, true);
            WriteLiteral(@"
<h1>Budget</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">Type</th>
            <th scope=""col"">Value</th>
            <th scope=""col"">Income/Expense</th>
            <th scope=""col"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
         foreach (IncomeViewModel i in Model.Incomes)
        {

#line default
#line hidden
            BeginContext(553, 50, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(604, 4, false);
#line 26 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                           Write(i.Id);

#line default
#line hidden
            EndContext();
            BeginContext(608, 39, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(648, 17, false);
#line 27 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                           Write(i.Date.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(665, 39, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(705, 12, false);
#line 28 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                           Write(i.IncomeType);

#line default
#line hidden
            EndContext();
            BeginContext(717, 39, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(757, 13, false);
#line 29 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                           Write(i.IncomeValue);

#line default
#line hidden
            EndContext();
            BeginContext(770, 71, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">Income</td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(852, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
         foreach (ExpenseViewModel e in Model.Expenses)
        {

#line default
#line hidden
            BeginContext(922, 50, true);
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(973, 4, false);
#line 37 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                           Write(e.Id);

#line default
#line hidden
            EndContext();
            BeginContext(977, 39, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(1017, 17, false);
#line 38 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                           Write(e.Date.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1034, 39, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(1074, 14, false);
#line 39 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                           Write(e.ExpensesType);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 39, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
            EndContext();
            BeginContext(1128, 15, false);
#line 40 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                           Write(e.ExpensesValue);

#line default
#line hidden
            EndContext();
            BeginContext(1143, 72, true);
            WriteLiteral("</td>\r\n                <td scope=\"row\">Expense</td>\r\n            </tr>\r\n");
            EndContext();
#line 43 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1226, 43, true);
            WriteLiteral("        <tr>\r\n            <td>Incomes Sum: ");
            EndContext();
            BeginContext(1270, 15, false);
#line 45 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                        Write(Model.IncomeSum);

#line default
#line hidden
            EndContext();
            BeginContext(1285, 68, true);
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>Expenses Sum: ");
            EndContext();
            BeginContext(1354, 16, false);
#line 49 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                         Write(Model.ExpenseSum);

#line default
#line hidden
            EndContext();
            BeginContext(1370, 62, true);
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>Budget: ");
            EndContext();
            BeginContext(1433, 11, false);
#line 53 "C:\Users\Kristijan\Desktop\budget app\BudgetApp\BudgetApp\Views\Budget\Index.cshtml"
                   Write(budgetValue);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 44, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BudgetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
