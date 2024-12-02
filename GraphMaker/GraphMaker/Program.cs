using System.Windows.Forms.DataVisualization.Charting;
using GraphMaker;

namespace GraphCreator
{
    public class Graph : Form
    {
        private readonly System.ComponentModel.IContainer components = null;
        Chart chart1;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Graph());
        }

        public Graph()
        {
            InitializeComponent();
        }

        private void LoadData(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var series1 = new Series
            {
                Name = "graph",
                Color = Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            chart1.Series.Add(series1);
            var points = new List<Model>()
            {
                new() {Close = 2.5M, Signal = false},
                new() {Close = 3.5M, Signal = true},
                new() {Close = 4.5M, Signal = true},
                new() {Close = 4.5M, Signal = false} ,
            };

            for (int i = 0; i < points.Count; i++)
            {
                var item = points[i];
                series1.Points.AddXY(i, item.Close);
                if (item.Signal == true)
                {
                    series1.Points[i].MarkerStyle = MarkerStyle.Triangle;
                    series1.Points[i].MarkerSize = 5;
                    series1.Points[i].MarkerColor = Color.Red;
                }
            }

            chart1.Invalidate();
        }

        private void InitializeComponent()
        {
            ChartArea chart = new();
            Legend legend1 = new();
            chart1 = new Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();

            chart.Name = "chart";
            chart1.ChartAreas.Add(chart);
            chart1.Dock = DockStyle.Fill;
            chart1.Location = new Point(0, 0);
            chart1.Margin = new Padding(4, 5, 4, 5);
            chart1.Name = "chart1";
            chart1.Size = new Size(379, 403);
            chart1.TabIndex = 0;

            AutoScaleMode = AutoScaleMode.Font;
            AutoScaleDimensions = new SizeF(7F, 22F);
            ClientSize = new Size(380, 400);
            Controls.Add(chart1);
            Margin = new Padding(2, 4, 3, 4);
            Text = "Graph";
            Load += LoadData;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }
    }
}
