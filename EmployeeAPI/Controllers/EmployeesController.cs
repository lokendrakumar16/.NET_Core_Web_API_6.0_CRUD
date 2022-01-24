using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee()
            {
                 EmpId = 1,
                 FirstName ="Lokendra",
                 LastName ="Kumar",
                 Email ="lokendra@gmail.com",
                 Phone ="9743585478",
                 DepartmentId = 2,
                 DesignationId = 3,
                 ManagerId = 4,
                Salary=10000
            },
            new Employee()
            {
                 EmpId = 2,
                 FirstName ="Deepika",
                 LastName ="Kashyap",
                 Email ="deepika@gmail.com",
                 Phone ="8878585545",
                 DepartmentId = 1,
                 DesignationId = 1,
                 ManagerId = 1,
                Salary=15000
            }

        };

        [HttpGet]
        public async Task<ActionResult<List<Employee>>> Get()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Employee>>> Get(int id)
        {
            var employee = employees.Find(e => e.EmpId == id);
            if (employee == null)
                return BadRequest("Employee not found.");
            return Ok(employee);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employee>>> Add(Employee emp)
        {
            employees.Add(emp);
            return Ok(employees);
        }

        [HttpPut]
        public async Task<ActionResult<List<Employee>>> Update(Employee emp)
        {
            var employee = employees.Find(e => e.EmpId == emp.EmpId);

            if (employee == null)
                return BadRequest("Employee not found to update.");

            employee.EmpId = emp.EmpId;
            employee.FirstName = emp.FirstName;
            employee.LastName = emp.LastName;
            employee.Email = emp.Email;
            employee.Phone = emp.Phone;
            employee.DepartmentId = emp.DepartmentId;
            employee.DesignationId = emp.DesignationId;
            employee.Salary = emp.Salary;

            return Ok(employees);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Employee>>> Delete(int id)
        {
            var employee = employees.Find(e => e.EmpId == id);
            if (employee == null)
                return BadRequest("Employee not found.");
            
            employees.Remove(employee);
            return Ok(employees);
        }

    }
}
