using Employee.Business;
using Employee.Business.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee employeeBL;

        public EmployeeController(IEmployee employee) {
            this.employeeBL = employee;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            return Ok(await employeeBL.GetAllEmployee(cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Post(EmployeeDto employeeDto, CancellationToken cancellationToken) {

          return Ok(await employeeBL.AddEmployee(employeeDto, cancellationToken));        
        }

    }
}
