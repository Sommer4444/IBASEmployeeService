namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }


        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "31",
                Name = "Kasper Sommer",
                Email = "kaso@ibas.dk",
                Department = new Department() { Id = 3, Name = "it" }
            },
            new Employee() {
                Id = "32",
                Name = "Lotte kode",
                Email = "loje@ibas.dk",
                Department = new Department() { Id = 3, Name = "it" }
            },
            new Employee() {
                Id = "33",
                Name = "Mads kode",
                Email = "mako@ibas.dk",
                Department = new Department() { Id = 3, Name = "it" }
            },
            new Employee() {
                Id = "41",
                Name = "Torben kok",
                Email = "koto@ibas.dk",
                Department = new Department() { Id = 4, Name = "kantinen" }
            },
            new Employee() {
                Id = "42",
                Name = "Hanne kok",
                Email = "hama@ibas.dk",
                Department = new Department() { Id = 4, Name = "kantinen" }
            }
        };
            return employees;
        }
        [HttpGet("GetByDepartment/{deptName}")]
        public IEnumerable<Employee> GetByDepartment(string deptName)
        {
            var allEmployees = Get(); 
            
            var filteredEmployees = allEmployees.Where(e => 
                e.Department.Name.Equals(deptName, StringComparison.OrdinalIgnoreCase));

            return filteredEmployees;
        }
    }
}