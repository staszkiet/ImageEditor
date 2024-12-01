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
            components = new System.ComponentModel.Container();
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
            deletepolygonButton = new Button();
            customButton = new RadioButton();
            bezierChart = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            trackBar1 = new TrackBar();
            contrastTrackBar = new TrackBar();
            BrightnessTrackBar = new TrackBar();
            gammaButton = new RadioButton();
            contrastButton = new RadioButton();
            brightnessButton = new RadioButton();
            applyButton = new Button();
            noFilterButton = new RadioButton();
            negateButton = new RadioButton();
            chartBlue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartGreen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartRed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            contextMenuStrip1 = new ContextMenuStrip(components);
            usuńPunktToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bezierChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contrastTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BrightnessTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRed).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(deletepolygonButton);
            splitContainer1.Panel2.Controls.Add(customButton);
            splitContainer1.Panel2.Controls.Add(bezierChart);
            splitContainer1.Panel2.Controls.Add(button3);
            splitContainer1.Panel2.Controls.Add(button2);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(trackBar1);
            splitContainer1.Panel2.Controls.Add(contrastTrackBar);
            splitContainer1.Panel2.Controls.Add(BrightnessTrackBar);
            splitContainer1.Panel2.Controls.Add(gammaButton);
            splitContainer1.Panel2.Controls.Add(contrastButton);
            splitContainer1.Panel2.Controls.Add(brightnessButton);
            splitContainer1.Panel2.Controls.Add(applyButton);
            splitContainer1.Panel2.Controls.Add(noFilterButton);
            splitContainer1.Panel2.Controls.Add(negateButton);
            splitContainer1.Panel2.Controls.Add(chartBlue);
            splitContainer1.Panel2.Controls.Add(chartGreen);
            splitContainer1.Panel2.Controls.Add(chartRed);
            splitContainer1.Size = new Size(1063, 744);
            splitContainer1.SplitterDistance = 498;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(498, 744);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // deletepolygonButton
            // 
            deletepolygonButton.Location = new Point(260, 698);
            deletepolygonButton.Name = "deletepolygonButton";
            deletepolygonButton.Size = new Size(154, 34);
            deletepolygonButton.TabIndex = 17;
            deletepolygonButton.Text = "usuń wielokąt";
            deletepolygonButton.UseVisualStyleBackColor = true;
            deletepolygonButton.Click += deletepolygonButton_Click;
            // 
            // customButton
            // 
            customButton.AutoSize = true;
            customButton.Location = new Point(292, 366);
            customButton.Name = "customButton";
            customButton.Size = new Size(96, 29);
            customButton.TabIndex = 16;
            customButton.TabStop = true;
            customButton.Text = "custom";
            customButton.UseVisualStyleBackColor = true;
            customButton.CheckedChanged += customButton_CheckedChanged;
            // 
            // bezierChart
            // 
            bezierChart.BackColor = SystemColors.ControlLightLight;
            bezierChart.Location = new Point(283, 402);
            bezierChart.Name = "bezierChart";
            bezierChart.Size = new Size(219, 227);
            bezierChart.TabIndex = 15;
            bezierChart.TabStop = false;
            bezierChart.Click += bezierChart_Click;
            bezierChart.Paint += bezierChart_Paint;
            bezierChart.DoubleClick += bezierChart_DoubleClick;
            bezierChart.MouseClick += bezierChart_MouseClick;
            bezierChart.MouseDown += bezierChart_MouseDown;
            bezierChart.MouseMove += bezierChart_MouseMove;
            bezierChart.MouseUp += bezierChart_MouseUp;
            // 
            // button3
            // 
            button3.Location = new Point(142, 658);
            button3.Name = "button3";
            button3.Size = new Size(144, 34);
            button3.TabIndex = 14;
            button3.Text = "dodaj wielokąt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 658);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "pędzel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(142, 698);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "zastosuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(292, 300);
            trackBar1.Maximum = 200;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(156, 69);
            trackBar1.TabIndex = 11;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // contrastTrackBar
            // 
            contrastTrackBar.Location = new Point(292, 190);
            contrastTrackBar.Maximum = 120;
            contrastTrackBar.Name = "contrastTrackBar";
            contrastTrackBar.Size = new Size(156, 69);
            contrastTrackBar.TabIndex = 10;
            contrastTrackBar.Value = 55;
            contrastTrackBar.ValueChanged += contrastTrackBar_ValueChanged;
            // 
            // BrightnessTrackBar
            // 
            BrightnessTrackBar.Location = new Point(292, 82);
            BrightnessTrackBar.Maximum = 255;
            BrightnessTrackBar.Name = "BrightnessTrackBar";
            BrightnessTrackBar.Size = new Size(156, 69);
            BrightnessTrackBar.TabIndex = 9;
            BrightnessTrackBar.Value = 100;
            BrightnessTrackBar.ValueChanged += BrightnessTrackBar_ValueChanged;
            // 
            // gammaButton
            // 
            gammaButton.AutoSize = true;
            gammaButton.Location = new Point(292, 265);
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
            contrastButton.Location = new Point(295, 155);
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
            brightnessButton.Location = new Point(292, 47);
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
            applyButton.Text = "wypełnij";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // noFilterButton
            // 
            noFilterButton.AutoSize = true;
            noFilterButton.Location = new Point(389, 12);
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
            negateButton.Location = new Point(292, 12);
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { usuńPunktToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(176, 36);
            // 
            // usuńPunktToolStripMenuItem
            // 
            usuńPunktToolStripMenuItem.Name = "usuńPunktToolStripMenuItem";
            usuńPunktToolStripMenuItem.Size = new Size(175, 32);
            usuńPunktToolStripMenuItem.Text = "Usuń punkt";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 744);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bezierChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)contrastTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BrightnessTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRed).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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
        private TrackBar BrightnessTrackBar;
        private TrackBar contrastTrackBar;
        private TrackBar trackBar1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox bezierChart;
        private RadioButton customButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem usuńPunktToolStripMenuItem;
        private Button deletepolygonButton;
    }
}
