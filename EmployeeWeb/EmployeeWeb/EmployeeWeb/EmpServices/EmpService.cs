using EmployeeWeb.Model;
using System.Text.Json;

namespace EmployeeWeb.EmpServices
{
    public class EmpService : IEmpService
    {
        private readonly HttpClient httpClient;
        public EmpService(IHttpClientFactory httpClientFactory) {
            this.httpClient = httpClientFactory.CreateClient(EndpointNames.Employee);
        }
        public async Task<EmployeeDto> AddEmployee(EmployeeDto employeeDto, CancellationToken cancellationToken)
        {           
            var response = await httpClient.PostAsJsonAsync<EmployeeDto>("Employee", employeeDto, cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<EmployeeDto>();
            }
            return null;
        }

        public async Task<List<EmployeeDto>> GetEmployee(CancellationToken cancellationToken)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var result = await httpClient.GetFromJsonAsync<List<EmployeeDto>>("Employee", jsonSerializerOptions, cancellationToken);
           
            return result ?? new List<EmployeeDto>();
        }
    }
}
