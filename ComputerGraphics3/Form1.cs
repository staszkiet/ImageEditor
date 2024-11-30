

using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ComputerGraphics3
{
    public partial class Form1 : Form
    {
        public int[] Red = new int[256];
        public int[] Green = new int[256];
        public int[] Blue = new int[256];
        public Bitmap original;
        public Bitmap b;
        public int radius = 20;
        public bool drawing = false;
        public bool mouseDown = false;
        public State stan = State.Brush;
        ModificationManager manager = new NothingManager();
        BezierFunc bezier;
        List<PointC> unfinishedShape = new List<PointC>();
        Shape? polygon = null;
        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, splitContainer1.Panel1, new object[] { true });
            original = new Bitmap("C:\\Users\\zaprz\\source\\repos\\ComputerGraphics3\\ComputerGraphics3\\Saul.jpg");
            b = new Bitmap(original);
            pictureBox1.Image = b;
            bezier = new BezierFunc(new Point(0, bezierChart.Height - 1), new Point(bezierChart.Width - 1, 0));
            CustomManager.mapping = bezier.mapping;
            MakeRedHistogram();
            MakeGreenHistogram();
            MakeBlueHistogram();
        }

        void UpdateHistograms()
        {
            CountRed();
            chartRed.Series[0].Points.Clear();
            for (int i = 0; i < Red.Length; i++)
            {
                chartRed.Series[0].Points.AddXY(i, Red[i]);
            }
            CountGreen();
            chartGreen.Series[0].Points.Clear();
            for (int i = 0; i < Green.Length; i++)
            {
                chartGreen.Series[0].Points.AddXY(i, Green[i]);
            }
            CountBlue();
            chartBlue.Series[0].Points.Clear();
            for (int i = 0; i < Blue.Length; i++)
            {
                chartBlue.Series[0].Points.AddXY(i, Blue[i]);
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (stan == State.AddPolygon)
            {
                foreach (PointC p in unfinishedShape)
                {
                    e.Graphics.FillEllipse(new SolidBrush(Color.Green), p.X - 3, p.Y - 3, 6, 6);
                }
            }
        }

        void MakeBlueHistogram()
        {
            CountBlue();
            chartBlue.Legends.Clear();
            chartBlue.Series.Clear();
            chartBlue.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Minimum = 0;
            chartBlue.ChartAreas.Add(chartArea);
            Series series = new Series
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                Name = "Histogram",
            };
            chartBlue.Series.Add(series);
            for (int i = 0; i < Blue.Length; i++)
            {
                series.Points.AddXY(i, Blue[i]);
            }
        }

        void MakeGreenHistogram()
        {
            CountGreen();
            chartGreen.Legends.Clear();
            chartGreen.Series.Clear();
            chartGreen.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Minimum = 0;
            chartGreen.ChartAreas.Add(chartArea);
            Series series = new Series
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Green,
                Name = "Histogram"

            };
            chartGreen.Series.Add(series);
            for (int i = 0; i < Green.Length; i++)
            {
                series.Points.AddXY(i, Green[i]);
            }
        }
        void MakeRedHistogram()
        {
            CountRed();
            chartRed.Legends.Clear();
            chartRed.Series.Clear();
            chartRed.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Minimum = 0;
            chartRed.ChartAreas.Add(chartArea);
            Series series = new Series
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Red,
                Name = "Histogram",
            };
            chartRed.Series.Add(series);
            for (int i = 0; i < Red.Length; i++)
            {
                series.Points.AddXY(i, Red[i]);
            }
        }

        void CountRed()
        {
            Red = new int[256];
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color r = b.GetPixel(i, j);
                    Red[r.R]++;
                }
            }
        }

        void CountGreen()
        {
            Green = new int[256];
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color r = b.GetPixel(i, j);
                    Green[r.G]++;
                }
            }
        }

        void CountBlue()
        {
            Blue = new int[256];
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color r = b.GetPixel(i, j);
                    Blue[r.B]++;
                }
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {

            chartRed.Update();
        }

        private void negateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (negateButton.Checked)
            {
                manager = new NegationManager();
            }
        }

        private void noFilterButton_CheckedChanged(object sender, EventArgs e)
        {
            if (noFilterButton.Checked)
            {
                manager = new NothingManager();
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color r = original.GetPixel(i, j);
                    Color new_color = manager.ModifyPixel(r);
                    b.SetPixel(i, j, new_color);
                }
            }
            UpdateHistograms();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void UpdateArea(int x, int y, int x2, int y2)
        {
            y = y < 0 ? 0 : y;
            x = x < 0 ? 0 : x;
            x2 = x2 >= b.Width ? b.Width - 1 : x2;
            y2 = y2 >= b.Height ? b.Height - 1 : y2;
            int centerX = x + radius;
            int centerY = y + radius;
            for (int i = x; i <= x2; i = i + 1)
            {
                for (int j = y; j <= y2; j = j + 1)
                {
                    if (Helpers.distance(i, j, centerX, centerY) <= radius)
                    {
                        Color r = original.GetPixel(i, j);
                        Color new_color = manager.ModifyPixel(r);
                        b.SetPixel(i, j, new_color);
                    }
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (stan == State.Brush)
            {
                drawing = true;
                if (e.X < b.Width && e.Y < b.Height)
                {
                    UpdateArea(e.X - radius, e.Y - radius, e.X + radius, e.Y + radius);
                }
            }
            else if (stan == State.AddPolygon)
            {
                if (polygon == null)
                {
                    if (unfinishedShape.Count > 0 && Helpers.distance(unfinishedShape[0].X, unfinishedShape[0].Y, e.X, e.Y) < 10)
                    {
                        polygon = new Shape(unfinishedShape, manager);
                        polygon.Fill(b, original, false);
                        unfinishedShape = new List<PointC>();
                    }
                    else
                    {
                        unfinishedShape.Add(new PointC(e.X, e.Y));
                    }
                }
            }
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            UpdateHistograms();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                if (e.X < b.Width && e.Y < b.Height)
                {
                    UpdateArea(e.X - radius, e.Y - radius, e.X + radius, e.Y + radius);
                }
            }
            pictureBox1.Invalidate();
        }

        private void brightnessButton_CheckedChanged(object sender, EventArgs e)
        {
            if (brightnessButton.Checked)
            {
                manager = new BrightnessManager();
            }
        }

        private void contrastButton_CheckedChanged(object sender, EventArgs e)
        {
            if (contrastButton.Checked)
            {
                manager = new ContrastManager();
            }
        }

        private void gammaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gammaButton.Checked)
            {
                manager = new GammaManager();
            }
        }

        private void BrightnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            BrightnessManager.light = BrightnessTrackBar.Value;
        }

        private void contrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ContrastManager.contrast_low = contrastTrackBar.Value;
            ContrastManager.constrast_high = 255 - contrastTrackBar.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            GammaManager.gamma = trackBar1.Value / 50d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            original = new Bitmap(b);
        }

        private void bezierChart_Paint(object sender, PaintEventArgs e)
        {
            bezier.Draw(e.Graphics);
        }

        private void bezierChart_Click(object sender, EventArgs e)
        {

        }

        private void bezierChart_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void bezierChart_MouseDown(object sender, MouseEventArgs e)
        {
            Point l = new Point(e.Location.X, e.Location.Y);
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 1; i < bezier.ControlPoints.Count - 1; i++)
                {
                    if (Helpers.distance(l.X, l.Y, bezier.ControlPoints[i].X, bezier.ControlPoints[i].Y) < 10)
                    {
                        bezier.ControlPoints.RemoveAt(i);
                        bezierChart.Invalidate();
                        return;
                    }
                }
            }
            mouseDown = true;
            for (int i = 1; i < bezier.ControlPoints.Count - 1; i++)
            {
                if (Helpers.distance(l.X, l.Y, bezier.ControlPoints[i].X, bezier.ControlPoints[i].Y) < 10)
                {
                    bezier.Selected = bezier.ControlPoints[i];
                    return;
                }
            }
            PointC pom = new PointC(l);
            int idx = bezier.ControlPoints.FindIndex((x) => x.X > l.X);
            bezier.ControlPoints.Insert(idx, pom);
            bezier.Selected = pom;
            bezierChart.Invalidate();
        }

        private void bezierChart_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                bezier.Selected.P = new Point(e.Location.X, e.Location.Y);
                bezierChart.Invalidate();
            }
        }

        private void bezierChart_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void customButton_CheckedChanged(object sender, EventArgs e)
        {
            if (customButton.Checked)
            {
                manager = new CustomManager();
            }
        }

        private void bezierChart_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            stan = State.AddPolygon;
            unfinishedShape = new List<PointC>();
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stan = State.Brush;
            pictureBox1.Invalidate();
        }

        private void deletepolygonButton_Click(object sender, EventArgs e)
        {
            polygon.Fill(b, original, true);
            polygon = null;
            pictureBox1.Invalidate();
        }
    }
    public enum State { Brush, AddPolygon }
}

