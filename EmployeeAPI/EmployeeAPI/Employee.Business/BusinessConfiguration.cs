using AutoMapper;
using Employee.Business.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Business
{
    public static class BusinessConfiguration
    {
        public static IServiceCollection AddBusinessConfiguration(this IServiceCollection service) {

            service.AddScoped<IEmployee, Employee>();
            AddMapperConfiguration(service);
            return service;
        }

        private static void AddMapperConfiguration(IServiceCollection services)
        {
            var mapperconfig = new MapperConfiguration(m =>
            {
                m.AddProfile(new EmployeeProfile());
            });
            services.AddSingleton<IMapper>(o => mapperconfig.CreateMapper());
        }
    }
}
