using AutoMapper;
using Employee.Business.Model;
using Employee.Data;
using Employee.Data.IRepositories;

namespace Employee.Business
{
    public class Employee : IEmployee
    {
        private readonly IEmployeeRepository repository;
        private readonly IMapper _mapper;

        public Employee(IEmployeeRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this._mapper = mapper;
        }

        public async Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto, CancellationToken cancellationToken = default)
        {
            var employee = _mapper.Map<TblEmpInfo>(employeeDto);
            return _mapper.Map<EmployeeDto>(await repository.AddEmployee(employee, cancellationToken));
        }

        public async Task<List<EmployeeDto>> GetAllEmployee(CancellationToken cancellationToken = default)
        {
            var result = _mapper.Map<List<EmployeeDto>>(await repository.GetEmployeeNames(cancellationToken));

            return result;
        }
    }
}