using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizbowlScoreTracker
{
    public partial class Statistics : Form
    {
        List<Player> players = new List<Player>();
        public Statistics()
        {
            InitializeComponent();

            string[] lines = File.ReadAllLines("ScoreHistory.txt");
            foreach (string line in lines)
            {
                string[] portions = line.Split(',');
                Player player = new Player(portions[0], portions.Skip(1).ToArray());
                players.Add(player);
            }
            foreach(Player player in players)
            {
                StatsLabel.Text += player.Name + "\n"
                                  + "Number of Negs" + player.NumNegs().ToString() + "\n"
                                  + "Number of Powers" + player.NumPowers().ToString() + "\n"
                                  + "Number of Tossups Heard" + player.NumTossupsHeard().ToString() + "\n"
                                  + "Points Per Game" + player.PointsPerGame().ToString() + "\n"
                                  + "Points Per Question" + player.PointsPerQuestion().ToString() + "\n"
                                  + "Power to Neg Ratio" + player.PowerToNegRatio().ToString() + "\n"
                                  + "Total Number of Points" + player.TotalNumPoints().ToString() + "\n";
            }
        }
    }
}
