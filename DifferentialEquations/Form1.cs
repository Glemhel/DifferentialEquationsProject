using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace DifferentialEquations
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            chartIVP.MouseWheel += chartIVPMouseWheel;
            chartLTE.MouseWheel += chartLTEMouseWheel;
        }

        private void button_plot_click(object sender, EventArgs e)
        {
            try
            {
                // collect data from text boxes on this tab
                double x0 = Double.Parse(textBoxIVPx0.Text); // x0 - initial value of x
                double y0 = Double.Parse(textBoxIVPy0.Text); // y0 - initial value of y
                double X = Double.Parse(textBoxIVPX.Text); // X - right border of the interval
                int N = Int32.Parse(textBoxIVPN.Text); // N - number of grid cells
                                                         // data is collected

                // Then we need to proceed this data to methods of solving IVP
                // in order to get the data to plot further

                EulerMethod EulerGrid = new EulerMethod(N, x0, y0, X, new MyFunction());
                chartIVP.Series["Euler"].Points.DataBindXY(EulerGrid.x, EulerGrid.y);

                ImprovedEulerMethod ImprovedEulerGrid = 
                    new ImprovedEulerMethod(N, x0, y0, X, new MyFunction());
                chartIVP.Series["ImprovedEuler"].Points.DataBindXY(ImprovedEulerGrid.x, ImprovedEulerGrid.y);

                Runge_KuttaMethod Runge_KuttaGrid =
                    new Runge_KuttaMethod(N, x0, y0, X, new MyFunction());
                chartIVP.Series["RungeKutta"].Points.DataBindXY(Runge_KuttaGrid.x, Runge_KuttaGrid.y);

                MyExactSolution myExactSolutionGrid = new MyExactSolution(N, x0, y0, X);
                chartIVP.Series["Exact"].Points.DataBindXY(myExactSolutionGrid.x, myExactSolutionGrid.y);

                chartIVP.ChartAreas[0].AxisX.Minimum = x0;
                chartIVP.ChartAreas[0].AxisX.Maximum = X;


                chartLTE.ChartAreas[0].AxisX.Minimum = x0;
                chartLTE.ChartAreas[0].AxisX.Maximum = X;

                LTEGrid LTEEuler = new LTEGrid(myExactSolutionGrid, EulerGrid);
                LTEGrid LTEImprovedEuler = new LTEGrid(myExactSolutionGrid, ImprovedEulerGrid);
                LTEGrid LTERungeKutta = new LTEGrid(myExactSolutionGrid, Runge_KuttaGrid);

                chartLTE.Series["Euler"].Points.DataBindXY(LTEEuler.x, LTEEuler.y);
                chartLTE.Series["ImprovedEuler"].Points.DataBindXY(LTEImprovedEuler.x, LTEImprovedEuler.y);
                chartLTE.Series["RungeKutta"].Points.DataBindXY(LTERungeKutta.x, LTERungeKutta.y);
            }
            catch
            {

            }
            
        }

        private void checkBoxIVPEulerCheckedChanged(object sender, EventArgs e)
        {
            chartIVP.Series["Euler"].Enabled = checkBoxIVPEuler.Checked;
            chartLTE.Series["Euler"].Enabled = checkBoxIVPEuler.Checked;
        }

        private void checkBoxIVPImprovedEulerCheckedChanged(object sender, EventArgs e)
        {
            chartIVP.Series["ImprovedEuler"].Enabled = checkBoxIVPImprovedEuler.Checked;
            chartLTE.Series["ImprovedEuler"].Enabled = checkBoxIVPImprovedEuler.Checked;

        }

        private void checkBoxIVPRungeKuttaCheckedChanged(object sender, EventArgs e)
        {
            chartIVP.Series["RungeKutta"].Enabled = checkBoxIVPRungeKutta.Checked;
            chartLTE.Series["RungeKutta"].Enabled = checkBoxIVPRungeKutta.Checked;

        }

        private void checkBoxIVPExactCheckedChanged(object sender, EventArgs e)
        {
            chartIVP.Series["Exact"].Enabled = checkBoxIVPExact.Checked;
        }

        private class ZoomFrame
        {
            public double XStart { get; set; }
            public double XFinish { get; set; }
            public double YStart { get; set; }
            public double YFinish { get; set; }
        }

        private readonly Stack<ZoomFrame> _zoomFrames = new Stack<ZoomFrame>();
        private void chartIVPMouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0)
                {
                    if (0 < _zoomFrames.Count)
                    {
                        var frame = _zoomFrames.Pop();
                        if (_zoomFrames.Count == 0)
                        {
                            xAxis.ScaleView.ZoomReset();
                            yAxis.ScaleView.ZoomReset();
                        }
                        else
                        {
                            xAxis.ScaleView.Zoom(frame.XStart, frame.XFinish);
                            yAxis.ScaleView.Zoom(frame.YStart, frame.YFinish);
                        }
                    }
                }
                else if (e.Delta > 0)
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    _zoomFrames.Push(new ZoomFrame { XStart = xMin, XFinish = xMax, YStart = yMin, YFinish = yMax });

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        private readonly Stack<ZoomFrame> _zoomFrames1 = new Stack<ZoomFrame>();
        private void chartLTEMouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0)
                {
                    if (0 < _zoomFrames1.Count)
                    {
                        var frame = _zoomFrames1.Pop();
                        if (_zoomFrames1.Count == 0)
                        {
                            xAxis.ScaleView.ZoomReset();
                            yAxis.ScaleView.ZoomReset();
                        }
                        else
                        {
                            xAxis.ScaleView.Zoom(frame.XStart, frame.XFinish);
                            yAxis.ScaleView.Zoom(frame.YStart, frame.YFinish);
                        }
                    }
                }
                else if (e.Delta > 0)
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    _zoomFrames1.Push(new ZoomFrame { XStart = xMin, XFinish = xMax, YStart = yMin, YFinish = yMax });

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
    }
}
