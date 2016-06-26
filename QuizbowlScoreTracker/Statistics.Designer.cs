namespace QuizbowlScoreTracker
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StatisticsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatisticsGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalNumPointsCheckBox = new System.Windows.Forms.CheckBox();
            this.NumTossupsHeardCheckBox = new System.Windows.Forms.CheckBox();
            this.PointsPerGameCheckBox = new System.Windows.Forms.CheckBox();
            this.PowerToNegCheckBox = new System.Windows.Forms.CheckBox();
            this.PointsPerQuestionCheckBox = new System.Windows.Forms.CheckBox();
            this.NumPowersCheckBox = new System.Windows.Forms.CheckBox();
            this.NumNegsCheckBox = new System.Windows.Forms.CheckBox();
            this.PlayersListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsChart)).BeginInit();
            this.StatisticsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatisticsChart
            // 
            chartArea1.Name = "ChartArea";
            this.StatisticsChart.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend";
            this.StatisticsChart.Legends.Add(legend1);
            this.StatisticsChart.Location = new System.Drawing.Point(218, 12);
            this.StatisticsChart.Name = "StatisticsChart";
            series1.ChartArea = "ChartArea";
            series1.Legend = "Legend";
            series1.Name = "Series";
            this.StatisticsChart.Series.Add(series1);
            this.StatisticsChart.Size = new System.Drawing.Size(699, 522);
            this.StatisticsChart.TabIndex = 1;
            // 
            // StatisticsGroupBox
            // 
            this.StatisticsGroupBox.Controls.Add(this.TotalNumPointsCheckBox);
            this.StatisticsGroupBox.Controls.Add(this.NumTossupsHeardCheckBox);
            this.StatisticsGroupBox.Controls.Add(this.PointsPerGameCheckBox);
            this.StatisticsGroupBox.Controls.Add(this.PowerToNegCheckBox);
            this.StatisticsGroupBox.Controls.Add(this.PointsPerQuestionCheckBox);
            this.StatisticsGroupBox.Controls.Add(this.NumPowersCheckBox);
            this.StatisticsGroupBox.Controls.Add(this.NumNegsCheckBox);
            this.StatisticsGroupBox.Location = new System.Drawing.Point(12, 335);
            this.StatisticsGroupBox.Name = "StatisticsGroupBox";
            this.StatisticsGroupBox.Size = new System.Drawing.Size(186, 199);
            this.StatisticsGroupBox.TabIndex = 2;
            this.StatisticsGroupBox.TabStop = false;
            this.StatisticsGroupBox.Text = "Statistics";
            // 
            // TotalNumPointsCheckBox
            // 
            this.TotalNumPointsCheckBox.AutoSize = true;
            this.TotalNumPointsCheckBox.Location = new System.Drawing.Point(23, 19);
            this.TotalNumPointsCheckBox.Name = "TotalNumPointsCheckBox";
            this.TotalNumPointsCheckBox.Size = new System.Drawing.Size(134, 17);
            this.TotalNumPointsCheckBox.TabIndex = 6;
            this.TotalNumPointsCheckBox.Text = "Total Number of Points";
            this.TotalNumPointsCheckBox.UseVisualStyleBackColor = true;
            this.TotalNumPointsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // NumTossupsHeardCheckBox
            // 
            this.NumTossupsHeardCheckBox.AutoSize = true;
            this.NumTossupsHeardCheckBox.Location = new System.Drawing.Point(23, 88);
            this.NumTossupsHeardCheckBox.Name = "NumTossupsHeardCheckBox";
            this.NumTossupsHeardCheckBox.Size = new System.Drawing.Size(150, 17);
            this.NumTossupsHeardCheckBox.TabIndex = 5;
            this.NumTossupsHeardCheckBox.Text = "Number of Tossups Heard";
            this.NumTossupsHeardCheckBox.UseVisualStyleBackColor = true;
            this.NumTossupsHeardCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // PointsPerGameCheckBox
            // 
            this.PointsPerGameCheckBox.AutoSize = true;
            this.PointsPerGameCheckBox.Location = new System.Drawing.Point(23, 65);
            this.PointsPerGameCheckBox.Name = "PointsPerGameCheckBox";
            this.PointsPerGameCheckBox.Size = new System.Drawing.Size(105, 17);
            this.PointsPerGameCheckBox.TabIndex = 4;
            this.PointsPerGameCheckBox.Text = "Points Per Game";
            this.PointsPerGameCheckBox.UseVisualStyleBackColor = true;
            this.PointsPerGameCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // PowerToNegCheckBox
            // 
            this.PowerToNegCheckBox.AutoSize = true;
            this.PowerToNegCheckBox.Location = new System.Drawing.Point(23, 111);
            this.PowerToNegCheckBox.Name = "PowerToNegCheckBox";
            this.PowerToNegCheckBox.Size = new System.Drawing.Size(123, 17);
            this.PowerToNegCheckBox.TabIndex = 2;
            this.PowerToNegCheckBox.Text = "Power To Neg Ratio";
            this.PowerToNegCheckBox.UseVisualStyleBackColor = true;
            this.PowerToNegCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // PointsPerQuestionCheckBox
            // 
            this.PointsPerQuestionCheckBox.AutoSize = true;
            this.PointsPerQuestionCheckBox.Location = new System.Drawing.Point(23, 42);
            this.PointsPerQuestionCheckBox.Name = "PointsPerQuestionCheckBox";
            this.PointsPerQuestionCheckBox.Size = new System.Drawing.Size(119, 17);
            this.PointsPerQuestionCheckBox.TabIndex = 3;
            this.PointsPerQuestionCheckBox.Text = "Points Per Question";
            this.PointsPerQuestionCheckBox.UseVisualStyleBackColor = true;
            this.PointsPerQuestionCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // NumPowersCheckBox
            // 
            this.NumPowersCheckBox.AutoSize = true;
            this.NumPowersCheckBox.Location = new System.Drawing.Point(23, 134);
            this.NumPowersCheckBox.Name = "NumPowersCheckBox";
            this.NumPowersCheckBox.Size = new System.Drawing.Size(113, 17);
            this.NumPowersCheckBox.TabIndex = 0;
            this.NumPowersCheckBox.Text = "Number of Powers";
            this.NumPowersCheckBox.UseVisualStyleBackColor = true;
            this.NumPowersCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // NumNegsCheckBox
            // 
            this.NumNegsCheckBox.AutoSize = true;
            this.NumNegsCheckBox.Location = new System.Drawing.Point(23, 157);
            this.NumNegsCheckBox.Name = "NumNegsCheckBox";
            this.NumNegsCheckBox.Size = new System.Drawing.Size(103, 17);
            this.NumNegsCheckBox.TabIndex = 1;
            this.NumNegsCheckBox.Text = "Number of Negs";
            this.NumNegsCheckBox.UseVisualStyleBackColor = true;
            this.NumNegsCheckBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // PlayersListBox
            // 
            this.PlayersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PlayersListBox.FormattingEnabled = true;
            this.PlayersListBox.ItemHeight = 25;
            this.PlayersListBox.Location = new System.Drawing.Point(12, 12);
            this.PlayersListBox.Name = "PlayersListBox";
            this.PlayersListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PlayersListBox.Size = new System.Drawing.Size(186, 304);
            this.PlayersListBox.TabIndex = 3;
            this.PlayersListBox.SelectedValueChanged += new System.EventHandler(this.PlayersListBox_SelectedValueChanged);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 546);
            this.Controls.Add(this.PlayersListBox);
            this.Controls.Add(this.StatisticsGroupBox);
            this.Controls.Add(this.StatisticsChart);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsChart)).EndInit();
            this.StatisticsGroupBox.ResumeLayout(false);
            this.StatisticsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StatisticsChart;
        private System.Windows.Forms.GroupBox StatisticsGroupBox;
        private System.Windows.Forms.CheckBox PointsPerGameCheckBox;
        private System.Windows.Forms.CheckBox PointsPerQuestionCheckBox;
        private System.Windows.Forms.CheckBox PowerToNegCheckBox;
        private System.Windows.Forms.CheckBox NumPowersCheckBox;
        private System.Windows.Forms.CheckBox NumNegsCheckBox;
        private System.Windows.Forms.CheckBox TotalNumPointsCheckBox;
        private System.Windows.Forms.CheckBox NumTossupsHeardCheckBox;
        private System.Windows.Forms.ListBox PlayersListBox;
    }
}