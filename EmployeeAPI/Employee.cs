namespace EmployeeAPI
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int ManagerId { get; set; }

        public float Salary { get; set; }

    }
}
