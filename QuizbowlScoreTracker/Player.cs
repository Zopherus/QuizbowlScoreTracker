using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizbowlScoreTracker
{
    class Player
    {
        public string Name { get; private set; }
        private int[] scores;

        public Player (string Name, string[] scores)
        {
            this.Name = Name;
            this.scores = Array.ConvertAll(scores, int.Parse);
        }

        public double PointsPerQuestion()
        {
            return (double)TotalNumPoints() / (double)NumTossupsHeard();
        }

        public double PointsPerGame()
        {
            return PointsPerQuestion() * 20.0;
        }

        public int NumNegs()
        {
            int counter = 0;
            foreach (int score in scores)
            {
                if (score == -5)
                    counter++;
            }
            return counter;
        }

        public int NumPowers()
        {
            int counter = 0;
            foreach (int score in scores)
            {
                if (score == 15)
                    counter++;
            }
            return counter;
        }

        public double PowerToNegRatio()
        {
            return (double)NumPowers() / (double)NumNegs();
        }

        public int NumTossupsHeard()
        {
            return scores.Length;
        }

        public int TotalNumPoints()
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return sum;
        }
    }
}
