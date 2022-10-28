using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data.IRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<TblEmpInfo>> GetEmployeeNames(CancellationToken cancellationToken = default);
        Task<TblEmpInfo> AddEmployee(TblEmpInfo empInfo,CancellationToken cancellationToken = default);
    }
}
