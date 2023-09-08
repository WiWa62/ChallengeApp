using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Alina";
            string lastName1 = "Abacka";
            int age1 = 24;
            Employee employee1 = new Employee(name1,lastName1,age1);
            employee1.AddScore(9);
            employee1.AddScore(8);
            employee1.AddScore(1);
            int result1 = employee1.Result;


            string name2 = "Bartosz";
            string lastName2 = "Babacki";
            int age2 = 24;
            Employee employee2 = new Employee(name2,lastName2,age2);
            employee2.AddScore(9);
            employee2.AddScore(4);
            employee2.AddScore(6);
            int result2 = employee2.Result;


            string name3 = "Celina";
            string lastName3 = "Cacacka";
            int age3 = 29;
            Employee employee3 = new Employee(name3,lastName3,age3);
            employee3.AddScore(8);
            employee3.AddScore(7);
            employee3.AddScore(4);
            int result3 = employee3.Result;


            //int max0 = Math.Max(result1,result2);
            //int max = Math.Max(max0, result3);
            //Console.WriteLine(max);



            int max = 0;
            if (result1 > result2 && result1 > result3)
            {
                max = result1;
                Console.WriteLine($"{name1} {lastName1}, lat {age1}, otrzymał/a najwięcej punktów - {employee1.Result}.");

            }//-----------------------------------------------------------------------------------------------------------

            else if (result1 == result2 && result1 > result3)
            {
                max = result1;
                Console.WriteLine("Dwie osoby otrzymały największą i jednocześnie równą liczbę punktów. Są to:");
                Console.WriteLine();
                Console.WriteLine($"{name1} {lastName1}, lat {age1}, otrzymał/a najwięcej punktów - {employee1.Result}.");
                Console.WriteLine($"{name2} {lastName2}, lat {age2}, otrzymał/a najwięcej punktów - {employee2.Result}.");
            }

            else if (result1 == result3 && result1 > result2)
            {
                max = result1;
                Console.WriteLine("Dwie osoby otrzymały największą i jednocześnie równą liczbę punktów. Są to:");
                Console.WriteLine();
                Console.WriteLine($"{name1} {lastName1}, lat {age1}, otrzymał/a najwięcej punktów - {employee1.Result}.");
                Console.WriteLine($"{name3} {lastName3}, lat {age3}, otrzymał/a najwięcej punktów - {employee3.Result}.");
            }

            else if (result2 == result3 && result2 > result1)
            {
                max = result1;
                Console.WriteLine("Dwie osoby otrzymały największą i jednocześnie równą liczbę punktów. Są to:");
                Console.WriteLine();
                Console.WriteLine($"{name2} {lastName2}, lat {age2}, otrzymał/a najwięcej punktów - {employee2.Result}.");
                Console.WriteLine($"{name3} {lastName3}, lat {age3}, otrzymał/a najwięcej punktów - {employee3.Result}.");
            }
            //--------------------------------------------------------------------------------------------------------------------------------------
            else if (result1 == result2 && result1 == result3)
            {
                max = result1;
                Console.WriteLine("Trzy osoby otrzymały największą i jednocześnie równą liczbę punktów. Są to:");
                Console.WriteLine();
                Console.WriteLine($"{name1} {lastName1}, lat {age1}, otrzymał/a najwięcej punktów - {employee1.Result}.");
                Console.WriteLine($"{name2} {lastName2}, lat {age2}, otrzymał/a najwięcej punktów - {employee2.Result}.");
                Console.WriteLine($"{name3} {lastName3}, lat {age3}, otrzymał/a najwięcej punktów - {employee3.Result}.");
            }
            //----------------------------------------------------------------------------------------------------------------------------------------
            else if (result2 > result1 && result2 > result3)
            {
                max = result2;
                Console.WriteLine($"{name2} {lastName2}, lat {age2}, otrzymał/a najwięcej punktów - {employee2.Result}.");
            }

            else if (result3 > result1 && result3 > result2)
            {
                max = result3;
                Console.WriteLine($"{name3} {lastName3}, lat {age3}, otrzymał/a najwięcej punktów - {employee3.Result}.");
            }
        }  
    }
}