﻿using AutoMapper;
using EmployeeManagement.Models;
using EmployeeManagement.Web.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeBase:ComponentBase
    {
        private  Employee Employee { get; set; } = new Employee();
        public string PageHeaderText { get; set; }

        [Inject] public IEmployeeService EmployeeService { get; set; }

        public EditEmployeeModel EditEmployeeModel { get; set; } = new EditEmployeeModel();

        [Inject] public IDepartmentService DepartmentService { get; set; }

        [Inject] public NavigationManager NavigationManager { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();

        [Parameter] public string Id { get; set; }

        public string DepartmentId { get; set; }
        [Inject] public IMapper Mapper { get; set; }
        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int employeeId);
            
            if(employeeId != 0)
            {
                PageHeaderText = "Edit Employee";
                Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            }
            else
            {
                PageHeaderText = "Create Employee";
                Employee = new Employee
                {
                    DepartmentId = 1,
                    DateOfBrith = DateTime.Now,
                    PhotoPath = " "
                };
            }

          

            Departments = (await DepartmentService.GetDepartments()).ToList();
            DepartmentId = Employee.DepartmentId.ToString();
            Mapper.Map(Employee, EditEmployeeModel);
        }

        protected async Task HandleValidSubmit()
        {
            Mapper.Map(EditEmployeeModel, Employee);
            Employee result = null;
            if(Employee.EmployeeId != 0)
            {
                result = await EmployeeService.EditEmployee(Employee);
            }
            else
            {
                result = await EmployeeService.CreateEmployee(Employee);
            }
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }

        protected async Task Delete_Click()
        {
            await EmployeeService.DeleteEmployee(Employee.EmployeeId);
            NavigationManager.NavigateTo("/");
        }
    }
}
