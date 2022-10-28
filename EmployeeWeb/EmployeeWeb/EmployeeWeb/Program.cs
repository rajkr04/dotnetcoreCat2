using EmployeeWeb.EmpServices;
using EmployeeWeb.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile($"appsettings.{(string.IsNullOrEmpty(environment) ? "Production" : environment)}.json", true);

builder.Services.Configure<EndpointOptions>(builder.Configuration);
var endpointOptions = builder.Configuration.Get<EndpointOptions>();

foreach (var endpoint in endpointOptions.ApiEndpoints) {

    builder.Services.AddHttpClient(endpoint.Name, o => {
        o.BaseAddress = new Uri(endpoint.Url);    
    });
}
builder.Services.AddServiceConfiguration();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
