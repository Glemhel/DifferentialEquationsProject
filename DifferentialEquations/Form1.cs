using System;
using System.Windows.Forms;

namespace DifferentialEquations
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // initialization of components
            InitializeComponent();
            // simulate click on the plot button to have the charts plotted on the start
            buttonIVPPlotClick(new object(), new System.EventArgs());
        }

        /*
         * Function to redraw charts based on the provided parameters by the user.
         * Triggers when button plot&analyze is clicked.
         */
        private void buttonIVPPlotClick(object sender, EventArgs e)
        {
            try
            {
                // collect data from text boxes on this tab
                double x0 = Double.Parse(textBoxx0.Text); // x0 - initial value of x
                double y0 = Double.Parse(textBoxy0.Text); // y0 - initial value of y
                double X = Double.Parse(textBoxX.Text); // X - right border of the interval
                int N = Int32.Parse(textBoxN.Text); // N - number of grid cells
                                                    // data is collected
                int nStart = Int32.Parse(textBoxnStart.Text); // nStart - left border for GTEAnalysis
                int nFinish = Int32.Parse(textBoxnFinish.Text); // nFinish - right border for GTEAnalysis

                // Solve IVP for each method and bind data to the charts so it will be plotted

                // Euler Method solution grid
                EulerMethod EulerGrid = new EulerMethod(N, x0, y0, X, new MyFunction());
                chartIVP.Series["Euler"].Points.DataBindXY(EulerGrid.x, EulerGrid.y);

                // Improved Euler method solution grid
                ImprovedEulerMethod ImprovedEulerGrid =
                    new ImprovedEulerMethod(N, x0, y0, X, new MyFunction());
                chartIVP.Series["ImprovedEuler"].Points.DataBindXY(ImprovedEulerGrid.x, ImprovedEulerGrid.y);

                // Runge Kutta method solution grid
                RungeKuttaMethod RungeKuttaGrid =
                    new RungeKuttaMethod(N, x0, y0, X, new MyFunction());
                chartIVP.Series["RungeKutta"].Points.DataBindXY(RungeKuttaGrid.x, RungeKuttaGrid.y);

                // Exact solution grid
                MyExactSolution myExactSolutionGrid = new MyExactSolution(N, x0, y0, X);
                chartIVP.Series["Exact"].Points.DataBindXY(myExactSolutionGrid.x, myExactSolutionGrid.y);

                // set limits on x-axis for charts

                // Initial Value Problem chart
                chartIVP.ChartAreas[0].AxisX.Minimum = x0;
                chartIVP.ChartAreas[0].AxisX.Maximum = X;
                // LTE analysis chart
                chartLTE.ChartAreas[0].AxisX.Minimum = x0;
                chartLTE.ChartAreas[0].AxisX.Maximum = X;
                // GTE analysis chart
                chartEA.ChartAreas[0].AxisX.Minimum = nStart;
                chartEA.ChartAreas[0].AxisX.Maximum = nFinish;

                // Compute LTE for each method and bind data to the charts so it will be plotted

                // LTE for Euler method grid
                Grid LTEEuler = EulerGrid.LTEGrid(myExactSolutionGrid);
                chartLTE.Series["Euler"].Points.DataBindXY(LTEEuler.x, LTEEuler.y);

                // LTE for Improved Euler method grid
                Grid LTEImprovedEuler = ImprovedEulerGrid.LTEGrid(myExactSolutionGrid);
                chartLTE.Series["ImprovedEuler"].Points.DataBindXY(LTEImprovedEuler.x, LTEImprovedEuler.y);

                // LTE for Runge Kutta method grid
                Grid LTERungeKutta = RungeKuttaGrid.LTEGrid(myExactSolutionGrid);
                chartLTE.Series["RungeKutta"].Points.DataBindXY(LTERungeKutta.x, LTERungeKutta.y);

                // Compute GTE for each method and bind data to the charts so it will be plotted

                // GTE Euler method analysis grid
                Grid GTEEuler = EulerGrid.GTEAnalysisGrid(nStart, nFinish);
                chartEA.Series["Euler"].Points.DataBindXY(GTEEuler.x, GTEEuler.y);

                // GTE Improved Euler method analysis grid
                Grid GTEImprovedEuler = ImprovedEulerGrid.GTEAnalysisGrid(nStart, nFinish);
                chartEA.Series["ImprovedEuler"].Points.DataBindXY(GTEImprovedEuler.x, GTEImprovedEuler.y);
                // GTE Runge Kutta method analysis grid
                Grid GTERungeKutta = RungeKuttaGrid.GTEAnalysisGrid(nStart, nFinish);
                chartEA.Series["RungeKutta"].Points.DataBindXY(GTERungeKutta.x, GTERungeKutta.y);

            }
            catch
            {

            }

        }
        /*
         * Checkbox Euler Method changed state - enable or disable display of this series on
         * all charts
         */
        private void checkBoxIVPEulerCheckedChanged(object sender, EventArgs e)
        {
            chartIVP.Series["Euler"].Enabled = checkBoxEuler.Checked;
            chartLTE.Series["Euler"].Enabled = checkBoxEuler.Checked;
            chartEA.Series["Euler"].Enabled = checkBoxEuler.Checked;
        }
        /*
         * Checkbox Improved Euler Method changed state - enable or disable display of this series on
         * all charts
         */
        private void checkBoxIVPImprovedEulerCheckedChanged(object sender, EventArgs e)
        {
            chartIVP.Series["ImprovedEuler"].Enabled = checkBoxImprovedEuler.Checked;
            chartLTE.Series["ImprovedEuler"].Enabled = checkBoxImprovedEuler.Checked;
            chartEA.Series["ImprovedEuler"].Enabled = checkBoxImprovedEuler.Checked;

        }
        /*
         * Checkbox Runge Kutta Method changed state - enable or disable display of this series on
         * all charts
         */
        private void checkBoxIVPRungeKuttaCheckedChanged(object sender, EventArgs e)
        {
            chartIVP.Series["RungeKutta"].Enabled = checkBoxRungeKutta.Checked;
            chartLTE.Series["RungeKutta"].Enabled = checkBoxRungeKutta.Checked;
            chartEA.Series["RungeKutta"].Enabled = checkBoxRungeKutta.Checked;

        }
        /*
         * Checkbox Exact solution - enable or disable display of this series on
         * IVP chart
         */
        private void checkBoxIVPExactCheckedChanged(object sender, EventArgs e)
        {
            chartIVP.Series["Exact"].Enabled = checkBoxExact.Checked;
        }

    }
}
