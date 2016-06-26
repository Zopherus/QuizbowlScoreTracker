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

        public double Stat(Statistic statistic)
        {
            switch(statistic)
            {
                case Statistic.TotalNumPoints:
                    return TotalNumPoints();
                case Statistic.PointsPerQuestion:
                    return PointsPerQuestion();
                case Statistic.PointsPerGame:
                    return PointsPerGame();
                case Statistic.NumTossupsHeard:
                    return NumTossupsHeard();
                case Statistic.PowerToNegRatio:
                    return PowerToNegRatio();
                case Statistic.NumPowers:
                    return NumPowers();
                case Statistic.NumNegs:
                    return NumNegs();
                default:
                    return 0;
            }
        }

        private double TotalNumPoints()
        {
            double sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return sum;
        }

        private double PointsPerQuestion()
        {
            return (double)TotalNumPoints() / (double)NumTossupsHeard();
        }

        private double PointsPerGame()
        {
            return PointsPerQuestion() * 20.0;
        }
        
        private double NumTossupsHeard()
        {
            return scores.Length;
        }
        
        private double PowerToNegRatio()
        {
            if (NumNegs() == 0.0 && NumPowers() > 0)
                return 100;
            return (double)NumPowers() / (double)NumNegs();
        }

        private double NumPowers()
        {
            int counter = 0;
            foreach (int score in scores)
            {
                if (score == 15)
                    counter++;
            }
            return counter;
        }

        private double NumNegs()
        {
            int counter = 0;
            foreach (int score in scores)
            {
                if (score == -5)
                    counter++;
            }
            return counter;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
