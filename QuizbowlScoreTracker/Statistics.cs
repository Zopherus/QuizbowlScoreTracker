using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace QuizbowlScoreTracker
{
    public enum Statistic { TotalNumPoints, PointsPerQuestion, PointsPerGame, NumTossupsHeard, PowerToNegRatio, NumPowers, NumNegs}
    public partial class Statistics : Form
    {
        private List<Player> Players = new List<Player>();
        private List<CheckBox> CheckBoxes = new List<CheckBox>(); 
        private Dictionary<CheckBox, Statistic> StatsDict = new Dictionary<CheckBox, Statistic>();
        public Statistics()
        {
            InitializeComponent();

            CheckBoxes.Add(TotalNumPointsCheckBox);
            CheckBoxes.Add(PointsPerQuestionCheckBox);
            CheckBoxes.Add(PointsPerGameCheckBox);
            CheckBoxes.Add(NumTossupsHeardCheckBox);
            CheckBoxes.Add(PowerToNegCheckBox);
            CheckBoxes.Add(NumPowersCheckBox);
            CheckBoxes.Add(NumNegsCheckBox);

            StatsDict.Add(TotalNumPointsCheckBox, Statistic.TotalNumPoints);
            StatsDict.Add(PointsPerQuestionCheckBox, Statistic.PointsPerQuestion);
            StatsDict.Add(PointsPerGameCheckBox, Statistic.PointsPerGame);
            StatsDict.Add(NumTossupsHeardCheckBox, Statistic.NumTossupsHeard);
            StatsDict.Add(PowerToNegCheckBox, Statistic.PowerToNegRatio);
            StatsDict.Add(NumPowersCheckBox, Statistic.NumPowers);
            StatsDict.Add(NumNegsCheckBox, Statistic.NumNegs);


            string[] lines = File.ReadAllLines("ScoreHistory.txt");
            foreach (string line in lines)
            {
                string[] portions = line.Split(',');
                Player player = new Player(portions[0], portions.Skip(1).ToArray());
                Players.Add(player);
            }
            foreach(Player player in Players)
            {
                PlayersListBox.Items.Add(player);
                /*StatsLabel.Text += player.Name + "\n"
                                  + "Number of Negs" + player.NumNegs().ToString() + "\n"
                                  + "Number of Powers" + player.NumPowers().ToString() + "\n"
                                  + "Number of Tossups Heard" + player.NumTossupsHeard().ToString() + "\n"
                                  + "Points Per Game" + player.PointsPerGame().ToString() + "\n"
                                  + "Points Per Question" + player.PointsPerQuestion().ToString() + "\n"
                                  + "Power to Neg Ratio" + player.PowerToNegRatio().ToString() + "\n"
                                  + "Total Number of Points" + player.TotalNumPoints().ToString() + "\n";*/
            }
            DrawChart();
        }

        private void DrawChart()
        {
            StatisticsChart.Series.Clear();
            foreach(CheckBox checkBox in CheckBoxes)
            {
                if (checkBox.Checked)
                {
                    Series series = StatisticsChart.Series.Add(checkBox.Text);
                    foreach (Player player in PlayersListBox.SelectedItems)
                    {
                        series.Points.AddXY(player.Name, player.Stat(StatsDict[checkBox]));
                    }
                }
            }
        }

        private void PlayersListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            DrawChart();
        }

        private void CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            DrawChart();
        }
    }
}
