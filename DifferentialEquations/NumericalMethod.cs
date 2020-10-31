using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentialEquations
{
    public abstract class NumericalMethod : Grid
    {

        abstract public double GetNextY(double xi, double yi, Function f);
        public NumericalMethod(int N, double x0, double y0, double X, Function f) : base(N, x0, X)
        {
            y[0] = y0;
            for (int i = 1; i <= N; i++)
            {
                y[i] = GetNextY(x[i - 1], y[i - 1], f);
            }
        }
    }
}
