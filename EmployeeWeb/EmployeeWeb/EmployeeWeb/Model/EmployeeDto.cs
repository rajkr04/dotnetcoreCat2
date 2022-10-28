namespace EmployeeWeb.Model
{
    public class EmployeeDto
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string EmailId { get; set; }
        public string EmpAddress { get; set; }
        public string Dept { get; set; }
        public int? Salary { get; set; }
    }
}
