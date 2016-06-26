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
    public partial class ScoreKeeping : Form
    {
        Dictionary<int, DataGridView> TeamsDict = new Dictionary<int, DataGridView>();
        Dictionary<int, TextBox> Team1Dict = new Dictionary<int, TextBox>();
        Dictionary<int, TextBox> Team2Dict = new Dictionary<int, TextBox>();


        public ScoreKeeping()
        {
            InitializeComponent();

            Team1Scores.Rows[0].Cells[0].Value = 1;
            Team2Scores.Rows[0].Cells[0].Value = 1;

            TeamsDict.Add(0, Team1Scores);
            TeamsDict.Add(1, Team2Scores);


            Team1Dict.Add(0, Team1Member1NameTextBox);
            Team1Dict.Add(1, Team1Member2NameTextBox);
            Team1Dict.Add(2, Team1Member3NameTextBox);
            Team1Dict.Add(3, Team1Member4NameTextBox);

            Team2Dict.Add(0, Team2Member1NameTextBox);
            Team2Dict.Add(1, Team2Member2NameTextBox);
            Team2Dict.Add(2, Team2Member3NameTextBox);
            Team2Dict.Add(3, Team2Member4NameTextBox);
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end this game?", "End Game", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            string[] lines = File.ReadAllLines("ScoreHistory.txt");
            List<List<string>> splitLines = new List<List<string>>();
            for (int counter = 0; counter < lines.Length; counter++)
            {
                splitLines.Add(lines[counter].Split(',').Cast<string>().ToList());
            }

            List<string> names = new List<string>();
            for (int counter = 0; counter < splitLines.Count; counter++)
            {
                names.Add(splitLines[counter][0]);
            }

            for (int team = 0; team < 2; team++)
            {
                Dictionary<int, TextBox> textBoxDictionary;
                if (team == 0)
                    textBoxDictionary = Team1Dict;
                else
                    textBoxDictionary = Team2Dict;
                for (int counter = 0; counter < 4; counter++)
                {
                    string name = textBoxDictionary[counter].Text;
                    if (name == "" || name == null || (name.Length >= 6 && name.Substring(0,6) == "Player"))
                        break;
                    List<string> linePortions = new List<string>();
                    for (int x = 0; x < TeamsDict[team].RowCount; x++)
                    {
                        string cell = "";
                        if (TeamsDict[team].Rows[x].Cells[counter + 1].Value == null || TeamsDict[team].Rows[x].Cells[counter + 1].Value.ToString() == "")
                            cell = "0";
                        else
                            cell = TeamsDict[team].Rows[x].Cells[counter + 1].Value.ToString();
                        linePortions.Add(cell);
                    }
                    // Remove the last index which will always be a 0 because the DataGridView automatically creates a new row 
                    linePortions.RemoveAt(linePortions.Count - 1);
                    if (names.Contains(name))
                    {
                        splitLines[names.IndexOf(name)].AddRange(linePortions);
                    }
                    else
                    {
                        linePortions.Insert(0, name);
                        splitLines.Add(linePortions);
                    }
                }
            }
            List<string> finalLines = new List<string>();
            foreach (List<string> list in splitLines)
            {
                finalLines.Add(string.Join(",", list));
            }
            File.WriteAllLines("ScoreHistory.txt", finalLines);
        }
        
        private void Team1Scores_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int counter = 0; counter < Team1Scores.RowCount; counter++)
            {
                Team1Scores.Rows[counter].Cells[0].Value = counter + 1;
            }
            Team1ScoreLabel.Text = "Team Score: " + SumGridView(Team1Scores).ToString();
            while (Team2Scores.RowCount < Team1Scores.RowCount)
            {
                Team2Scores.Rows.Add();
            }
        }

        private void Team1Scores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Team1ScoreLabel.Text = "Team Score: " + SumGridView(Team1Scores).ToString();
        }
        
        private void Team2Scores_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int counter = 0; counter < Team2Scores.RowCount; counter++)
            {
                Team2Scores.Rows[counter].Cells[0].Value = counter + 1;
            }
            Team2ScoreLabel.Text = "Team Score: " + SumGridView(Team2Scores).ToString();
            while (Team1Scores.RowCount < Team2Scores.RowCount)
            {
                Team1Scores.Rows.Add();
            }
        }
        
        private void Team2Scores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Team2ScoreLabel.Text = "Team Score: " + SumGridView(Team2Scores).ToString();
        }

        private int SumGridView(DataGridView gridView)
        {
            int sum = 0;
            for (int x = 1; x < gridView.ColumnCount; x++)
            {
                for (int y = 0; y < gridView.RowCount; y++)
                {
                    if (gridView.Rows[y].Cells[x].Value != null)
                    {
                        int number = 0;
                        int.TryParse(gridView.Rows[y].Cells[x].Value.ToString(), out number);
                        sum += number;
                    }
                }
            }
            return sum;
        }

        private void StatisticsButton_Click(object sender, EventArgs e)
        {
            Statistics stats = new Statistics();
            stats.ShowDialog();
        }

        private void TextBoxGotFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = "";
            textBox.GotFocus -= TextBoxGotFocus;
        }
    }
}
