using Employee.Data.IRepositories;
using Employee.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data
{
    public static class DataConfiguration
    {

        public static IServiceCollection UseDataConfiguration(this IServiceCollection service, IConfiguration configuration) {

            service.AddDbContext<EmpdbContext>(option => option.UseSqlServer(configuration.GetConnectionString(nameof(EmpdbContext))));
            service.AddScoped<IEmployeeRepository, EmployeeRepository>(); 
            return service;
        }        

    }
}
