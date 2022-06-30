#pragma checksum "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Pages\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b4f157a8eca27315b069162357541a77fb6f322"
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
#line 1 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Models;

#line default
#line hidden
#nullable disable
    public partial class DisplayEmployee : DisplayEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddAttribute(2, "style", "min-width: 18rem; max-width:30.5%;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-header");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                          CheckBoxChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 8 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
             Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, "  ");
            __builder.AddContent(12, 
#nullable restore
#line 8 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                  Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 11 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                   Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
     if(@ShowFooter){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card-footer text-center ");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", 
#nullable restore
#line 18 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                  $"/EmployeeDetails/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "class", "btn btn-primary m-1");
            __builder.AddContent(22, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 20 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                  $"/editEmployee/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "class", "btn btn-primary m-1");
            __builder.AddContent(27, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.AddMarkupContent(29, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>");
            __builder.CloseElement();
#nullable restore
#line 24 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Pages\DisplayEmployee.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
