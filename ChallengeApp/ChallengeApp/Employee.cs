using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        string name;
        string lastName;
        int age;

        private List< int >  score = new List< int >();

        public Employee(string name,string lastName,int age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }

        
        public string Name {get; set; }
        public string LastName {get;set;}
        public int Age {get; set;}
        public int Score {get;}
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
