using AutoMapper;
using Employee.Business.Model;
using Employee.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Business.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {

            CreateMap<EmployeeDto, TblEmpInfo>();
            CreateMap<TblEmpInfo, EmployeeDto>();
        }
    }
}
