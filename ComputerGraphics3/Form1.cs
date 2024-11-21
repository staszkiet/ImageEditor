

using Microsoft.VisualBasic.ApplicationServices;
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
        public readonly Bitmap original;
        public Bitmap b;
        public int radius = 10;
        public Modification mod = Modification.noFilter;
        public bool drawing = false;
        int light = 100;
        int contrast_low = 55;
        int constrast_high = 200;
        double gamma = 2d;
        public Form1()
        {
            InitializeComponent();
            original = new Bitmap("C:\\Users\\zaprz\\source\\repos\\ComputerGraphics3\\ComputerGraphics3\\Saul.jpg");
            b = new Bitmap(original);
            pictureBox1.Image = b;
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
                mod = Modification.negate;
            }
        }

        private void noFilterButton_CheckedChanged(object sender, EventArgs e)
        {
            if (noFilterButton.Checked)
            {
                mod = Modification.noFilter;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (mod == Modification.negate)
            {
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color r = original.GetPixel(i, j);
                        Color new_color = Color.FromArgb(255 - r.R, 255 - r.G, 255 - r.B);
                        b.SetPixel(i, j, new_color);
                    }
                }
            }
            else if (mod == Modification.noFilter)
            {
                b = new Bitmap(original);
                pictureBox1.Image = b;
            }
            else if (mod == Modification.light)
            {
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color r = original.GetPixel(i, j);
                        Color new_color = Color.FromArgb(Helpers.Brighten(r.R, light), Helpers.Brighten(r.G, light), Helpers.Brighten(r.B, light));
                        b.SetPixel(i, j, new_color);
                    }
                }
            }
            else if (mod == Modification.contrast)
            {

                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c = original.GetPixel(i, j);
                        Color new_color = Color.FromArgb(Helpers.Contrast(c.R, contrast_low, constrast_high), Helpers.Contrast(c.G, contrast_low, constrast_high), Helpers.Contrast(c.B, contrast_low, constrast_high));
                        b.SetPixel(i, j, new_color);
                    }
                }
            }
            else if(mod == Modification.gamma)
            {
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color r = original.GetPixel(i, j);
                        Color new_color = Color.FromArgb(Helpers.nigamma(r.R, gamma), Helpers.nigamma(r.G, gamma), Helpers.nigamma(r.B, gamma));
                        b.SetPixel(i, j, new_color);
                    }
                }
            }
            UpdateHistograms();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void GammaArea(int x, int y, int x2, int y2)
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
                        Color new_color = Color.FromArgb(Helpers.nigamma(r.R, gamma), Helpers.nigamma(r.G, gamma), Helpers.nigamma(r.B, gamma));
                        b.SetPixel(i, j, new_color);
                    }
                }
            }
        }

        void ContrastArea(int x, int y, int x2, int y2)
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
                        Color c = original.GetPixel(i, j);
                        Color new_color = Color.FromArgb(Helpers.Contrast(c.R, contrast_low, constrast_high), Helpers.Contrast(c.G, contrast_low, constrast_high), Helpers.Contrast(c.B, contrast_low, constrast_high));
                        b.SetPixel(i, j, new_color);
                    }
                }
            }
        }
        void BrightenArea(int x, int y, int x2, int y2)
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
                        Color new_color = Color.FromArgb(Helpers.Brighten(r.R, light), Helpers.Brighten(r.G, light), Helpers.Brighten(r.B, light));
                        b.SetPixel(i, j, new_color);
                    }
                }
            }
        }
        void NegateArea(int x, int y, int x2, int y2)
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
                        Color new_color = Color.FromArgb(255 - r.R, 255 - r.G, 255 - r.B);
                        b.SetPixel(i, j, new_color);
                    }
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            if (e.X < b.Width && e.Y < b.Height)
            {
                if (mod == Modification.negate)
                {
                    NegateArea(e.X - radius, e.Y - radius, e.X + radius, e.Y + radius);
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
                    if (mod == Modification.negate)
                    {
                        NegateArea(e.X - radius, e.Y - radius, e.X + radius, e.Y + radius);
                    }
                    else if (mod == Modification.light)
                    {
                        BrightenArea(e.X - radius, e.Y - radius, e.X + radius, e.Y + radius);
                    }
                    else if (mod == Modification.contrast)
                    {
                        ContrastArea(e.X - radius, e.Y - radius, e.X + radius, e.Y + radius);
                    }
                    else if (mod == Modification.gamma)
                    {
                        GammaArea(e.X - radius, e.Y - radius, e.X + radius, e.Y + radius);
                    }
                }
            }
            pictureBox1.Invalidate();
        }

        private void brightnessButton_CheckedChanged(object sender, EventArgs e)
        {
            if (brightnessButton.Checked)
            {
                mod = Modification.light;
            }
        }

        private void contrastButton_CheckedChanged(object sender, EventArgs e)
        {
            if (contrastButton.Checked)
            {
                mod = Modification.contrast;
            }
        }

        private void gammaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (gammaButton.Checked)
            {
                mod = Modification.gamma;
            }
        }
    }

    public enum Modification{ negate, noFilter, light, contrast, gamma}
}
