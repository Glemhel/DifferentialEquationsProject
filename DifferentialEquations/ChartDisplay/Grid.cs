namespace DifferentialEquations
{
    /*
     * Class for representing Grid to plot it further
     */
    public class Grid
    {
        public double[] x; // x coordinates of the grid
        public double[] y; // y coordinates of the grid
        public int N; // number of cells in the grid
        public double h; // step of the grid

        /*
         * Basic constructor by number of cells in the grid N, left border x0, right border X
         */
        public Grid(int N, double x0, double X)
        {
            // compute grid step
            h = (X - x0) / N;

            // initialize empty arrays for coordinates
            x = new double[N + 1];
            y = new double[N + 1];

            // initialize length
            this.N = N;

            // initialize x-values of coordinates
            x[0] = x0;
            for (int i = 1; i <= N; i++)
            {
                x[i] = x[0] + h * i;
            }

            // initialization of y-values is left to the descendants

        }

        /*
         * Constructor of the grid when left and right borders are integers - and step is 1 as N is not passed
         */
        public Grid(int x0, int X)
        {
            // grid step is 1 in this case
            h = 1;

            // number of cells
            N = X - x0;

            // initialize empty arrays for coordinates
            x = new double[N + 1];
            y = new double[N + 1];

            // initialize x-values of coordinates
            x[0] = x0;
            for (int i = 1; i <= N; i++)
            {
                x[i] = x[i - 1] + 1;
            }

            // initialization of y-values is left to the descendants

        }
    }
}
