using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new("Alina", "Abacka", 21);
            employee1.AddScore(9);
            employee1.AddScore(6);
            employee1.AddScore(9);
            
            
            Employee employee2 = new("Bartosz","Babacki",24);
            employee2.AddScore(7);
            employee2.AddScore(9);
            employee2.AddScore(8);
            
            Employee employee3 = new("Celina","Cacacka",29);
            employee3.AddScore(8);
            employee3.AddScore(7);
            employee3.AddScore(6);

            List<Employee> employees = new List<Employee>(){employee1, employee2, employee3};

            int maxResult = -1;
            Employee employeeWithMaxResult = null;

            foreach (Employee employee in employees)
            {
                if (employee.Result > maxResult)
                {
                    employeeWithMaxResult = employee;
                    maxResult = employee.Result;
                }
            }

            Console.WriteLine($"Najwyższy wynik {employeeWithMaxResult.Result} pkt zdobywa {employeeWithMaxResult.Name}"
                + " " + $"{employeeWithMaxResult.LastName}" + " " + $"({employeeWithMaxResult.Age} lat/a)");
        }  
    }
}