using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        public List<int> score = new();
        public Employee()
        {
            Name = "";
            LastName = "";
            Age = 0;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int score)
        {
            {
                this.score.Add(score);
            }
        }
    }
}
