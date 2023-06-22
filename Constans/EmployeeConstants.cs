using ApiJwt.Models;

namespace ApiJwt.Constans
{
    public class EmployeeConstants
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee()
            {
                FirstName= "Paula",
                LastName = "Gomez",
                Email = "pgomez@fliagilgomez@outlook.com"
            },
            new Employee()
            {
                FirstName= "Samuel",
                LastName = "Gil",
                Email = "sgil@fliagilgomez@outlook.com"
            },
            new Employee()
            {
                FirstName= "Luciana",
                LastName = "Gil",
                Email = "LGil@fliagilgomez@outlook.com"
            }
        };
    }
}
