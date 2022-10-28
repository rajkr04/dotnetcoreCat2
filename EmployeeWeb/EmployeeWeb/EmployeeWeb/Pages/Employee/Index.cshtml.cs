using EmployeeWeb.EmpServices;
using EmployeeWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeWeb.Pages.Employee
{
    public class IndexModel : PageModel
    {
        public List<EmployeeDto> EmployeeDtos { get; set; } = new List<EmployeeDto>();

        private readonly IEmpService _empService;

        public IndexModel(IEmpService empService) {

            _empService = empService;
        }
        public async Task OnGet(CancellationToken cancellationToken)
        {
            EmployeeDtos = await _empService.GetEmployee(cancellationToken);
        }        
    }
}
