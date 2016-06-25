namespace QuizbowlScoreTracker
{
    partial class ScoreKeeping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Team1Scores = new System.Windows.Forms.DataGridView();
            this.Member1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team1Member1NameTextBox = new System.Windows.Forms.TextBox();
            this.Team1Member2NameTextBox = new System.Windows.Forms.TextBox();
            this.Team1Member3NameTextBox = new System.Windows.Forms.TextBox();
            this.Team1Member4NameTextBox = new System.Windows.Forms.TextBox();
            this.Team1ScoreLabel = new System.Windows.Forms.Label();
            this.EndGameButton = new System.Windows.Forms.Button();
            this.Team1NameLabel = new System.Windows.Forms.Label();
            this.Team1NameTextBox = new System.Windows.Forms.TextBox();
            this.Team2NameTextBox = new System.Windows.Forms.TextBox();
            this.Team2Namelabel = new System.Windows.Forms.Label();
            this.Team2ScoreLabel = new System.Windows.Forms.Label();
            this.Team2Member4NameTextBox = new System.Windows.Forms.TextBox();
            this.Team2Member3NameTextBox = new System.Windows.Forms.TextBox();
            this.Team2Member2NameTextBox = new System.Windows.Forms.TextBox();
            this.Team2Member1NameTextBox = new System.Windows.Forms.TextBox();
            this.Team2Scores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatisticsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Team1Scores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Team2Scores)).BeginInit();
            this.SuspendLayout();
            // 
            // Team1Scores
            // 
            this.Team1Scores.AllowUserToDeleteRows = false;
            this.Team1Scores.AllowUserToResizeColumns = false;
            this.Team1Scores.AllowUserToResizeRows = false;
            this.Team1Scores.ColumnHeadersHeight = 20;
            this.Team1Scores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Team1Scores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Member1,
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.Team1Scores.Location = new System.Drawing.Point(10, 58);
            this.Team1Scores.MultiSelect = false;
            this.Team1Scores.Name = "Team1Scores";
            this.Team1Scores.RowHeadersVisible = false;
            this.Team1Scores.RowHeadersWidth = 40;
            this.Team1Scores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Team1Scores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Team1Scores.Size = new System.Drawing.Size(442, 323);
            this.Team1Scores.StandardTab = true;
            this.Team1Scores.TabIndex = 0;
            this.Team1Scores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Team1Scores_CellValueChanged);
            this.Team1Scores.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Team1Scores_RowsAdded);
            // 
            // Member1
            // 
            this.Member1.HeaderText = "";
            this.Member1.Name = "Member1";
            this.Member1.ReadOnly = true;
            this.Member1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Member1.Width = 20;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Team1Member1NameTextBox
            // 
            this.Team1Member1NameTextBox.Location = new System.Drawing.Point(31, 58);
            this.Team1Member1NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Team1Member1NameTextBox.Name = "Team1Member1NameTextBox";
            this.Team1Member1NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team1Member1NameTextBox.TabIndex = 1;
            // 
            // Team1Member2NameTextBox
            // 
            this.Team1Member2NameTextBox.Location = new System.Drawing.Point(131, 58);
            this.Team1Member2NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Team1Member2NameTextBox.Name = "Team1Member2NameTextBox";
            this.Team1Member2NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team1Member2NameTextBox.TabIndex = 2;
            // 
            // Team1Member3NameTextBox
            // 
            this.Team1Member3NameTextBox.Location = new System.Drawing.Point(231, 58);
            this.Team1Member3NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Team1Member3NameTextBox.Name = "Team1Member3NameTextBox";
            this.Team1Member3NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team1Member3NameTextBox.TabIndex = 3;
            // 
            // Team1Member4NameTextBox
            // 
            this.Team1Member4NameTextBox.Location = new System.Drawing.Point(331, 58);
            this.Team1Member4NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Team1Member4NameTextBox.Name = "Team1Member4NameTextBox";
            this.Team1Member4NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team1Member4NameTextBox.TabIndex = 4;
            // 
            // Team1ScoreLabel
            // 
            this.Team1ScoreLabel.AutoSize = true;
            this.Team1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1ScoreLabel.Location = new System.Drawing.Point(93, 433);
            this.Team1ScoreLabel.Name = "Team1ScoreLabel";
            this.Team1ScoreLabel.Size = new System.Drawing.Size(176, 31);
            this.Team1ScoreLabel.TabIndex = 5;
            this.Team1ScoreLabel.Text = "Team Score: ";
            // 
            // EndGameButton
            // 
            this.EndGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EndGameButton.Location = new System.Drawing.Point(382, 494);
            this.EndGameButton.Name = "EndGameButton";
            this.EndGameButton.Size = new System.Drawing.Size(156, 58);
            this.EndGameButton.TabIndex = 6;
            this.EndGameButton.Text = "End Game";
            this.EndGameButton.UseVisualStyleBackColor = true;
            this.EndGameButton.Click += new System.EventHandler(this.EndGameButton_Click);
            // 
            // Team1NameLabel
            // 
            this.Team1NameLabel.AutoSize = true;
            this.Team1NameLabel.Location = new System.Drawing.Point(63, 25);
            this.Team1NameLabel.Name = "Team1NameLabel";
            this.Team1NameLabel.Size = new System.Drawing.Size(68, 13);
            this.Team1NameLabel.TabIndex = 7;
            this.Team1NameLabel.Text = "Team Name:";
            // 
            // Team1NameTextBox
            // 
            this.Team1NameTextBox.Location = new System.Drawing.Point(137, 22);
            this.Team1NameTextBox.Name = "Team1NameTextBox";
            this.Team1NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team1NameTextBox.TabIndex = 8;
            // 
            // Team2NameTextBox
            // 
            this.Team2NameTextBox.Location = new System.Drawing.Point(619, 22);
            this.Team2NameTextBox.Name = "Team2NameTextBox";
            this.Team2NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team2NameTextBox.TabIndex = 16;
            // 
            // Team2Namelabel
            // 
            this.Team2Namelabel.AutoSize = true;
            this.Team2Namelabel.Location = new System.Drawing.Point(545, 25);
            this.Team2Namelabel.Name = "Team2Namelabel";
            this.Team2Namelabel.Size = new System.Drawing.Size(68, 13);
            this.Team2Namelabel.TabIndex = 15;
            this.Team2Namelabel.Text = "Team Name:";
            // 
            // Team2ScoreLabel
            // 
            this.Team2ScoreLabel.AutoSize = true;
            this.Team2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2ScoreLabel.Location = new System.Drawing.Point(575, 433);
            this.Team2ScoreLabel.Name = "Team2ScoreLabel";
            this.Team2ScoreLabel.Size = new System.Drawing.Size(176, 31);
            this.Team2ScoreLabel.TabIndex = 14;
            this.Team2ScoreLabel.Text = "Team Score: ";
            // 
            // Team2Member4NameTextBox
            // 
            this.Team2Member4NameTextBox.Location = new System.Drawing.Point(813, 58);
            this.Team2Member4NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Team2Member4NameTextBox.Name = "Team2Member4NameTextBox";
            this.Team2Member4NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team2Member4NameTextBox.TabIndex = 13;
            // 
            // Team2Member3NameTextBox
            // 
            this.Team2Member3NameTextBox.Location = new System.Drawing.Point(713, 58);
            this.Team2Member3NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Team2Member3NameTextBox.Name = "Team2Member3NameTextBox";
            this.Team2Member3NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team2Member3NameTextBox.TabIndex = 12;
            // 
            // Team2Member2NameTextBox
            // 
            this.Team2Member2NameTextBox.Location = new System.Drawing.Point(613, 58);
            this.Team2Member2NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Team2Member2NameTextBox.Name = "Team2Member2NameTextBox";
            this.Team2Member2NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team2Member2NameTextBox.TabIndex = 11;
            // 
            // Team2Member1NameTextBox
            // 
            this.Team2Member1NameTextBox.Location = new System.Drawing.Point(513, 58);
            this.Team2Member1NameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.Team2Member1NameTextBox.Name = "Team2Member1NameTextBox";
            this.Team2Member1NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.Team2Member1NameTextBox.TabIndex = 10;
            // 
            // Team2Scores
            // 
            this.Team2Scores.AllowUserToDeleteRows = false;
            this.Team2Scores.AllowUserToResizeColumns = false;
            this.Team2Scores.AllowUserToResizeRows = false;
            this.Team2Scores.ColumnHeadersHeight = 20;
            this.Team2Scores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Team2Scores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.Team2Scores.Location = new System.Drawing.Point(492, 58);
            this.Team2Scores.MultiSelect = false;
            this.Team2Scores.Name = "Team2Scores";
            this.Team2Scores.RowHeadersVisible = false;
            this.Team2Scores.RowHeadersWidth = 40;
            this.Team2Scores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Team2Scores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Team2Scores.Size = new System.Drawing.Size(442, 323);
            this.Team2Scores.StandardTab = true;
            this.Team2Scores.TabIndex = 9;
            this.Team2Scores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Team2Scores_CellValueChanged);
            this.Team2Scores.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Team2Scores_RowsAdded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Location = new System.Drawing.Point(748, 505);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(75, 23);
            this.StatisticsButton.TabIndex = 17;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = true;
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // ScoreKeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 580);
            this.Controls.Add(this.StatisticsButton);
            this.Controls.Add(this.Team2NameTextBox);
            this.Controls.Add(this.Team2Namelabel);
            this.Controls.Add(this.Team2ScoreLabel);
            this.Controls.Add(this.Team2Member4NameTextBox);
            this.Controls.Add(this.Team2Member3NameTextBox);
            this.Controls.Add(this.Team2Member2NameTextBox);
            this.Controls.Add(this.Team2Member1NameTextBox);
            this.Controls.Add(this.Team2Scores);
            this.Controls.Add(this.Team1NameTextBox);
            this.Controls.Add(this.Team1NameLabel);
            this.Controls.Add(this.EndGameButton);
            this.Controls.Add(this.Team1ScoreLabel);
            this.Controls.Add(this.Team1Member4NameTextBox);
            this.Controls.Add(this.Team1Member3NameTextBox);
            this.Controls.Add(this.Team1Member2NameTextBox);
            this.Controls.Add(this.Team1Member1NameTextBox);
            this.Controls.Add(this.Team1Scores);
            this.Name = "ScoreKeeping";
            this.Text = "Score Keeping";
            ((System.ComponentModel.ISupportInitialize)(this.Team1Scores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Team2Scores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Team1Scores;
        private System.Windows.Forms.TextBox Team1Member1NameTextBox;
        private System.Windows.Forms.TextBox Team1Member2NameTextBox;
        private System.Windows.Forms.TextBox Team1Member3NameTextBox;
        private System.Windows.Forms.TextBox Team1Member4NameTextBox;
        private System.Windows.Forms.Label Team1ScoreLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button EndGameButton;
        private System.Windows.Forms.Label Team1NameLabel;
        private System.Windows.Forms.TextBox Team1NameTextBox;
        private System.Windows.Forms.TextBox Team2NameTextBox;
        private System.Windows.Forms.Label Team2Namelabel;
        private System.Windows.Forms.Label Team2ScoreLabel;
        private System.Windows.Forms.TextBox Team2Member4NameTextBox;
        private System.Windows.Forms.TextBox Team2Member3NameTextBox;
        private System.Windows.Forms.TextBox Team2Member2NameTextBox;
        private System.Windows.Forms.TextBox Team2Member1NameTextBox;
        private System.Windows.Forms.DataGridView Team2Scores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button StatisticsButton;
    }
}