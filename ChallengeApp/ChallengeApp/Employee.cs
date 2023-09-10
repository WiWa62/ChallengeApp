using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        public List< int >  score = new ();

        public string name;
        public string lastName;
        public int age;


        public Employee(string name,string lastName,int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }
        public int Result
        {
            get 
            { 
              return this.score.Sum();
            }
        }

        public void AddScore(int score) 
        { 
            this.score.Add(score);
        }
    }
}
