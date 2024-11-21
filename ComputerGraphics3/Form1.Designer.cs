namespace ComputerGraphics3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            gammaButton = new RadioButton();
            contrastButton = new RadioButton();
            brightnessButton = new RadioButton();
            applyButton = new Button();
            noFilterButton = new RadioButton();
            negateButton = new RadioButton();
            chartBlue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartGreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRed).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(gammaButton);
            splitContainer1.Panel2.Controls.Add(contrastButton);
            splitContainer1.Panel2.Controls.Add(brightnessButton);
            splitContainer1.Panel2.Controls.Add(applyButton);
            splitContainer1.Panel2.Controls.Add(noFilterButton);
            splitContainer1.Panel2.Controls.Add(negateButton);
            splitContainer1.Panel2.Controls.Add(chartBlue);
            splitContainer1.Panel2.Controls.Add(chartGreen);
            splitContainer1.Panel2.Controls.Add(chartRed);
            splitContainer1.Size = new Size(978, 744);
            splitContainer1.SplitterDistance = 459;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 744);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // gammaButton
            // 
            gammaButton.AutoSize = true;
            gammaButton.Location = new Point(236, 613);
            gammaButton.Name = "gammaButton";
            gammaButton.Size = new Size(98, 29);
            gammaButton.TabIndex = 8;
            gammaButton.TabStop = true;
            gammaButton.Text = "gamma";
            gammaButton.UseVisualStyleBackColor = true;
            gammaButton.CheckedChanged += gammaButton_CheckedChanged;
            // 
            // contrastButton
            // 
            contrastButton.AutoSize = true;
            contrastButton.Location = new Point(126, 648);
            contrastButton.Name = "contrastButton";
            contrastButton.Size = new Size(101, 29);
            contrastButton.TabIndex = 7;
            contrastButton.TabStop = true;
            contrastButton.Text = "contrast";
            contrastButton.UseVisualStyleBackColor = true;
            contrastButton.CheckedChanged += contrastButton_CheckedChanged;
            // 
            // brightnessButton
            // 
            brightnessButton.AutoSize = true;
            brightnessButton.Location = new Point(126, 613);
            brightnessButton.Name = "brightnessButton";
            brightnessButton.Size = new Size(104, 29);
            brightnessButton.TabIndex = 6;
            brightnessButton.TabStop = true;
            brightnessButton.Text = "brighten";
            brightnessButton.UseVisualStyleBackColor = true;
            brightnessButton.CheckedChanged += brightnessButton_CheckedChanged;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(24, 698);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(112, 34);
            applyButton.TabIndex = 5;
            applyButton.Text = "zastosuj";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // noFilterButton
            // 
            noFilterButton.AutoSize = true;
            noFilterButton.Location = new Point(29, 648);
            noFilterButton.Name = "noFilterButton";
            noFilterButton.Size = new Size(98, 29);
            noFilterButton.TabIndex = 4;
            noFilterButton.TabStop = true;
            noFilterButton.Text = "no filter";
            noFilterButton.UseVisualStyleBackColor = true;
            noFilterButton.CheckedChanged += noFilterButton_CheckedChanged;
            // 
            // negateButton
            // 
            negateButton.AutoSize = true;
            negateButton.Location = new Point(29, 613);
            negateButton.Name = "negateButton";
            negateButton.Size = new Size(91, 29);
            negateButton.TabIndex = 3;
            negateButton.TabStop = true;
            negateButton.Text = "negate";
            negateButton.UseVisualStyleBackColor = true;
            negateButton.CheckedChanged += negateButton_CheckedChanged;
            // 
            // chartBlue
            // 
            chartArea1.Name = "ChartArea1";
            chartBlue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartBlue.Legends.Add(legend1);
            chartBlue.Location = new Point(24, 411);
            chartBlue.Name = "chartBlue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartBlue.Series.Add(series1);
            chartBlue.Size = new Size(243, 177);
            chartBlue.TabIndex = 2;
            chartBlue.Text = "chart1";
            // 
            // chartGreen
            // 
            chartArea2.Name = "ChartArea1";
            chartGreen.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartGreen.Legends.Add(legend2);
            chartGreen.Location = new Point(24, 213);
            chartGreen.Name = "chartGreen";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGreen.Series.Add(series2);
            chartGreen.Size = new Size(243, 182);
            chartGreen.TabIndex = 1;
            chartGreen.Text = "chart1";
            // 
            // chartRed
            // 
            chartArea3.Name = "ChartArea1";
            chartRed.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartRed.Legends.Add(legend3);
            chartRed.Location = new Point(24, 12);
            chartRed.Name = "chartRed";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartRed.Series.Add(series3);
            chartRed.Size = new Size(243, 186);
            chartRed.TabIndex = 0;
            chartRed.Text = "chart1";
            chartRed.Click += chart1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 744);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRed).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGreen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBlue;
        private RadioButton negateButton;
        private RadioButton noFilterButton;
        private Button applyButton;
        private RadioButton brightnessButton;
        private RadioButton contrastButton;
        private RadioButton gammaButton;
    }
}
