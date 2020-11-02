using System;

namespace DifferentialEquations
{
    /*
     * Abstract class representing any NumericalMethod.
     * Inherits Grid
     */
    public abstract class NumericalMethod : Grid
    {
        // function that numerical method uses while execution
        readonly Function f;
        // abstract method - every numerical has it, but its own one - that computes next
        // value in the grid given previous
        abstract public double GetNextY(double xi, double yi, double h, Function f);

        // Construction of the LTEGrid for this NumericalMethod grid
        public Grid LTEGrid(Grid exactSolutionGrid)
        {
            // initialization of grid to return
            Grid grid = new Grid(N, x[0], x[N]);
            grid.y[0] = 0;
            for (int i = 1; i <= N; i++)
            {
                // caclulate next Value based on the previous exact value
                double nextVal = GetNextY(x[i - 1], exactSolutionGrid.y[i - 1], h, f);
                // compute LTE
                grid.y[i] = exactSolutionGrid.y[i] - nextVal;
            }
            // return desired grid
            return grid;
        }

        /*
         * Compute GTE values given two arrays - numerical solution and exact.
         * Here we need to just substract two arrays
         */
        private double[] GTEValues(double[] yNumerical, double[] yExact)
        {
            // initialization of the array to return later
            double[] values = new double[yNumerical.Length];
            for (int i = 0; i <= N; i++)
            {
                // compute GTE values for each step
                values[i] = yNumerical[i] - yExact[i];
            }
            // return array of y coordinates for the GTEGrid
            return values;
        }

        /*
         * Although this method is not used in the charts, I provide it for the convenience and completeness.
         * Constructs GTE Grid for the given numerical method solution.
         */
        public Grid GTEGrid(Grid exactSolutionGrid)
        {
            // grid for the GTE
            Grid grid = new Grid(N, exactSolutionGrid.x[0], exactSolutionGrid.x[N]);
            // compute y-values for the grid
            grid.y = GTEValues(ComputeValues(exactSolutionGrid.x, y[0]), exactSolutionGrid.y);
            // return GTE grid
            return grid;
        }

        /*
         * Provides grid that is analysis of GTE for different number of grid cells
         * Analysis n from nStart to nFinish
         */
        public Grid GTEAnalysisGrid(int nStart, int nFinish)
        {
            // grid to fill in
            Grid grid = new Grid(nStart, nFinish);
            // enumerate ovel all n
            for (int n = nStart; n <= nFinish; n++)
            {
                // construct exact solution grid with given number of steps
                MyExactSolution myExactSolutionGrid = new MyExactSolution(n, x[0], y[0], x[N]);
                // compute numerical method approximation for the given n
                double[] yNumerical = ComputeValues(myExactSolutionGrid.x, y[0]);
                double[] yExact = myExactSolutionGrid.y;
                // find maximum error in the grid
                grid.y[n - nStart] = Math.Abs(yNumerical[0] - yExact[0]);
                for (int i = 1; i <= n; i++)
                {
                    grid.y[n - nStart] = Math.Max(grid.y[n - nStart], Math.Abs(yNumerical[i] - yExact[i]));
                }
            }
            // return GTE analysis grid for plotting
            return grid;
        }

        /*
         * Compute numerical approximation of the y values based on initial conditions
         */
        private double[] ComputeValues(double[] x, double y0)
        {
            // array of approximations
            double[] y = new double[x.Length];
            // initial value
            y[0] = y0;
            for (int i = 1; i < x.Length; i++)
            {
                // recompute next y based on the previous one
                y[i] = GetNextY(x[i - 1], y[i - 1], x[1] - x[0], f);
            }
            // return approximations of values of a function on a given range x
            return y;
        }

        /*
         * Basic constuctor: uses Grid to fill x
         * fill y coordinates with the use of ComputeValues for the given
         */
        public NumericalMethod(int N, double x0, double y0, double X, Function f) : base(N, x0, X)
        {
            this.f = f;
            y = ComputeValues(x, y0);
        }
    }

}
