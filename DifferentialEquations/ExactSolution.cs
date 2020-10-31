using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentialEquations
{
    public abstract class ExactSolution : Grid
    {
        public abstract double exactSolutionFunction(double x, double x0, double y0);

        public ExactSolution(int N, double x0, double y0, double X) : base(N, x0, X)
        {
            for (int i = 0; i <= N; i++)
            {
                y[i] = exactSolutionFunction(x[i], x0, y0);
            }
        }
    }
}
