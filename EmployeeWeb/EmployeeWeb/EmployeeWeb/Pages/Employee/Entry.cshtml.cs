using EmployeeWeb.EmpServices;
using EmployeeWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmployeeWeb.Pages.Employee
{
    public class EntryModel : PageModel
    {

        public EmployeeDto EmployeeDto { get; set; } = new EmployeeDto();

        private readonly IEmpService _empService;

        public EntryModel(IEmpService empService)
        {
            _empService = empService;
        }
        public void OnGet()
        {
        }
        public async void OnPost(EmployeeDto employeeDto, CancellationToken cancellationToken)
        {            
            var result = await _empService.AddEmployee(employeeDto, cancellationToken);

        }

    }
}
