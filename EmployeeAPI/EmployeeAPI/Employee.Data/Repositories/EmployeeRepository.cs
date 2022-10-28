using Employee.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmpdbContext _empdbContext;

        public EmployeeRepository(EmpdbContext empdbContext)
        {
            this._empdbContext = empdbContext;
        }
        public async Task<TblEmpInfo> AddEmployee(TblEmpInfo empInfo, CancellationToken cancellationToken = default)
        {
            try
            {
                var result = await _empdbContext.TblEmpInfo.AddAsync(empInfo);
                await _empdbContext.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex) {
                throw ex;
            }            
        }

        public async Task<List<TblEmpInfo>> GetEmployeeNames(CancellationToken cancellationToken = default)
        {
            var result = await _empdbContext.TblEmpInfo.AsNoTracking()
                                       .Select(x => new TblEmpInfo()
                                       {
                                           Name = x.Name,
                                           EmpId = x.EmpId,
                                           EmpAddress = x.EmpAddress,
                                           Mobile = x.Mobile,
                                           EmailId = x.EmailId,
                                           Dept = x.Dept,
                                           Salary = x.Salary
                                       }).ToListAsync(cancellationToken);
            return result;
        }
    }
}
