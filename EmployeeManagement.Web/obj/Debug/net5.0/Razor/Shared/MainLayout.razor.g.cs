#pragma checksum "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91204c181703426fc1161a39160f741c018de694"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-s2kthycp59");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-s2kthycp59");
            __builder.OpenComponent<EmployeeManagement.Web.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-s2kthycp59");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4 container");
            __builder.AddAttribute(13, "b-s2kthycp59");
            __builder.AddContent(14, 
#nullable restore
#line 12 "F:\Rakib,IT\P. Project\Blazor Project\EmployeeManagement.Models\EmployeeManagement.Web\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
