//using ScottPlot;

//namespace GraphMaker
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void CreateChart()
//        {
//            formsPlot1.Plot.Clear();
//            double[] dataX = [1, 2, 3, 4, 5];
//            double[] datay = [12, 21, 13, 24, 15];
//            //formsPlot1.Plot.Add.Signal(dataX);
//            formsPlot1.Plot.Add.Scatter(dataX, datay);
//            formsPlot1.Plot.Axes.AutoScale();
//            formsPlot1.Refresh();
//        }

//        private void FormsPlot1_Load(object sender, EventArgs e)
//        {
//            CreateChart();
//        }
//    }
//}
using ScottPlot.WinForms;
using System.Windows.Forms;

namespace GraphMaker
{
    public partial class Form1 : Form
    {
        // Create an instance of a FormsPlot like this
        readonly FormsPlot FormsPlot1 = new FormsPlot() { Dock = DockStyle.Fill };

        public Form1()
        {
            InitializeComponent();
            Panel panel1 = new();
            // Add the FormsPlot to the panel
            panel1.Controls.Add(FormsPlot1);

            // Plot data using the control
            double[] data = ScottPlot.Generate.Sin();
            FormsPlot1.Plot.Add.Signal(data);
            FormsPlot1.Refresh();
        }
    }
}
