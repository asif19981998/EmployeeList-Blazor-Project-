using EmployeeManagement.Api.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeDbContext _db;

        public EmployeeController(EmployeeDbContext db)
        {
            _db = db;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
           return  _db.employees.ToList();
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _db.employees
                .Include(e=>e.Department)
                .FirstOrDefault(em => em.EmployeeId == id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public Employee Post(Employee employee)
        {
            _db.employees.Add(employee);
            bool isAdded = _db.SaveChanges() > 0;
            return employee;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut]
        public  Employee Put(Employee employee)
        {
             _db.employees.Update(employee);
             bool isAdded = _db.SaveChanges() > 0;
            return employee;

        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
