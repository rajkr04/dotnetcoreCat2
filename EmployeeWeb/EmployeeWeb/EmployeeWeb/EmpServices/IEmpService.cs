using EmployeeWeb.Model;

namespace EmployeeWeb.EmpServices
{
    public interface IEmpService
    {
        Task<List<EmployeeDto>> GetEmployee(CancellationToken cancellationToken);
        Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto,CancellationToken cancellationToken);
    }
}
