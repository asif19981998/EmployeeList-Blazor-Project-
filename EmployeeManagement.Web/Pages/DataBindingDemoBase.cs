using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class DataBindingDemoBase:ComponentBase
    {
        protected string Name { get; set; } = "Mehedi";
        protected string Gender { get; set; } = "Male";

        protected string Colour { get; set; } = "background-color:white";
    }
}
