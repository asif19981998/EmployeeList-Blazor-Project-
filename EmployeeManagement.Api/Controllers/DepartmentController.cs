using EmployeeManagement.Api.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private EmployeeDbContext _db;

        public DepartmentController(EmployeeDbContext db)
        {
            _db = db;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return _db.departments.ToList();
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public Department Get(int id)
        {
            return _db.departments
                .FirstOrDefault(em => em.DepartmentId == id);
        }

        // POST api/<DepartmentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DepartmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
