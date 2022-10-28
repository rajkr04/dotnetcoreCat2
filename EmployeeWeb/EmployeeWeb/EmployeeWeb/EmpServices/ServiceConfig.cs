namespace EmployeeWeb.EmpServices
{
    public struct EndpointNames
    {
        public const string Employee = nameof(Employee);
    }
    public static class ServiceConfig
    {
        public static IServiceCollection AddServiceConfiguration(this IServiceCollection services) {

            services.AddScoped<IEmpService, EmpService>();
            return services;
        } 
    }
}
