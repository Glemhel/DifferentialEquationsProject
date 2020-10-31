using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentialEquations
{
    public class Grid
    {
        public double[] x;
        public double[] y;
        public int N;
        public double h;

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
                x[i] = x[i - 1] + h;
            }

            // initialization of y-values is left to the descendants

        }
    }
}
