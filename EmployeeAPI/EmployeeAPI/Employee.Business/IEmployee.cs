using Employee.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Business
{
    public interface IEmployee
    {
        Task<List<EmployeeDto>> GetAllEmployee(CancellationToken cancellationToken = default);

        Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto, CancellationToken cancellationToken = default);
    }
}
