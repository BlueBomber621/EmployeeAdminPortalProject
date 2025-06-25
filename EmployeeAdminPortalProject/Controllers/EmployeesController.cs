using EmployeeAdminPortalProject.Data;
using EmployeeAdminPortalProject.Models;
using EmployeeAdminPortalProject.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAdminPortalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var allEmployees = dbContext.Employees.ToList();

            return Ok(allEmployees);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetSingleEmployee(Guid id)
        {
            var foundEmployee = dbContext.Employees.Find(id);

            if (foundEmployee == null)
            {
                return NotFound();
            }

            return Ok(foundEmployee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addData)
        {
            var newEmployee = new Employee()
            {
                Name = addData.Name,
                Email = addData.Email,
                Phone = addData.Phone,
                Salary = addData.Salary,
            };

            dbContext.Employees.Add(newEmployee);
            dbContext.SaveChanges();

            return Ok(newEmployee);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public IActionResult EditEmployee(Guid id, EditEmployeeDto editData)
        {
            var foundEmployee = dbContext.Employees.Find(id);

            if (foundEmployee == null)
            {
                return NotFound();
            }

            foundEmployee.Name = editData.Name;
            foundEmployee.Email = editData.Email;
            foundEmployee.Phone = editData.Phone;
            foundEmployee.Salary = editData.Salary;

            dbContext.SaveChanges();

            return Ok(foundEmployee);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var foundEmployee = dbContext.Employees.Find(id);

            if (foundEmployee == null)
            {
                return NotFound();
            }

            dbContext.Employees.Remove(foundEmployee);
            dbContext.SaveChanges();

            return Ok(foundEmployee);
        }
    }
}
