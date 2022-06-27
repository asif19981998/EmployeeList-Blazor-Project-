#pragma checksum "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ee7b6988d02d91d44e7e0b1aa09d3b5f3683340"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Selected Employee Count - ");
            __builder.AddContent(2, 
#nullable restore
#line 5 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
                               SelectedEmployeesCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "checkbox");
            __builder.AddAttribute(6, "id", "showFooter");
            __builder.AddAttribute(7, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                              ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShowFooter = __value, ShowFooter));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.AddMarkupContent(10, "<label for=\"showFooter\">Show Footer</label>");
#nullable restore
#line 10 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<div class=\"spinner\"></div>");
#nullable restore
#line 13 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-deck");
#nullable restore
#line 17 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
         foreach (var employee in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<EmployeeManagement.Web.Pages.DisplayEmployee>(14);
            __builder.AddAttribute(15, "Employee", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<EmployeeManagement.Models.Employee>(
#nullable restore
#line 19 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                       employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                             ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnEmployeeSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 19 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                                                              EmployeeSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 20 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "E:\C Sharp Practise Projects\Blazor Project\EmployeeList-Blazor-Project-\EmployeeManagement.Web\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
