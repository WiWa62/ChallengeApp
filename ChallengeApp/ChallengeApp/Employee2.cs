using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee2
    {
        private List<int> score = new List<int>();

        public Employee2(string Name, string LastName, int Age, int Score)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Age = Age;
            this.Score = Score;
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
            this.score.Add(score);
        }

    }
}
