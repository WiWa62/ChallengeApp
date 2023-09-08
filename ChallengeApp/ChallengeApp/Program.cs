using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            string lastName = null;
            int age = 0;
            int score = 0;
            Employee1 employee1 = new Employee1(name, lastName, age, score);
            Employee2 employee2 = new Employee2(name, lastName, age, score);
            Employee3 employee3 = new Employee3(name, lastName, age, score);

            employee1.Name = "Alina";
            employee1.LastName = "Abacka";
            employee1.Age = 24;
            employee1.AddScore(8);
            employee1.AddScore(1);
            employee1.AddScore(6);
            int result1 = employee1.Result;

            employee2.Name = "Bartosz";
            employee2.LastName = "Babacki";
            employee2.Age = 32;
            employee2.AddScore(9);
            employee2.AddScore(4);
            employee2.AddScore(4);
            int result2 = employee2.Result;

            employee3.Name = "Celina";
            employee3.LastName = "Cacacka";
            employee3.Age = 29;
            employee3.AddScore(8);
            employee3.AddScore(4);
            employee3.AddScore(2);
            int result3 = employee3.Result;


            //int max0 = Math.Max(result1,result2);
            //int max = Math.Max(max0, result3);
            //Console.WriteLine(max);



            int max = 0;
            if (result1 > result2 && result1 > result3)
            {
                max = result1;
                Console.WriteLine($"{employee1.Name} {employee1.LastName}, lat {employee1.Age}, otrzymał/a najwięcej punktów - {employee1.Result}.");
            }

            else if (result1 == result2 && result1 > result3)
            {
                max = result1;
                Console.WriteLine($"{employee1.Name} {employee1.LastName}, lat {employee1.Age}, otrzymał/a najwięcej punktów - {employee1.Result}.");
                Console.WriteLine($"{employee2.Name} {employee2.LastName}, lat {employee2.Age}, otrzymał/a najwięcej punktów - {employee2.Result}.");
            }

            else if (result1 == result3 && result1 > result2)
            {
                max = result1;
                Console.WriteLine($"{employee1.Name} {employee1.LastName}, lat {employee1.Age}, otrzymał/a najwięcej punktów - {employee1.Result}.");
                Console.WriteLine($"{employee3.Name} {employee3.LastName}, lat {employee3.Age}, otrzymał/a najwięcej punktów - {employee3.Result}.");
            }

            else if (result2 == result3 && result2 > result1)
            {
                max = result1;
                Console.WriteLine($"{employee2.Name} {employee2.LastName}, lat {employee2.Age}, otrzymał/a najwięcej punktów - {employee2.Result}.");
                Console.WriteLine($"{employee3.Name} {employee3.LastName}, lat {employee3.Age}, otrzymał/a najwięcej punktów - {employee3.Result}.");
            }
            //--------------------------------------------------------------------------------------------------------------------------------------
            else if (result1 == result2 && result1 == result3)
            {
                max = result1;
                Console.WriteLine($"{employee1.Name} {employee1.LastName}, lat {employee1.Age}, otrzymał/a najwięcej punktów - {employee1.Result}.");
                Console.WriteLine($"{employee2.Name} {employee2.LastName}, lat {employee2.Age}, otrzymał/a najwięcej punktów - {employee2.Result}.");
                Console.WriteLine($"{employee3.Name} {employee3.LastName}, lat {employee3.Age}, otrzymał/a najwięcej punktów - {employee3.Result}.");
            }

            else if (result2 > result1 && result2 > result3)
            {
                max = result2;
                Console.WriteLine($"{employee2.Name} {employee2.LastName}, lat {employee2.Age}, otrzymał/a najwięcej punktów - {employee2.Result}.");
            }

            else if (result3 > result1 && result3 > result2)
            {
                max = result3;
                Console.WriteLine($"{employee3.Name} {employee3.LastName}, lat {employee3.Age}, otrzymał/a najwięcej punktów - {employee3.Result}.");
            }
        }  
    }
}