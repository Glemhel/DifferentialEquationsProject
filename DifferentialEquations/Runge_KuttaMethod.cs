using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentialEquations
{
    public class Runge_KuttaMethod : NumericalMethod
    {
        public override double GetNextY(double xi, double yi, Function f)
        {
            double k1 = f.F(xi, yi);
            double k2 = f.F(xi + h / 2, yi + k1 * h / 2);
            double k3 = f.F(xi + h / 2, yi + k2 * h / 2);
            double k4 = f.F(xi + h, yi + h * k3);
            return yi + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
        }

        public Runge_KuttaMethod(int N, double x0, double y0, double X, Function f) : base(N, x0, y0, X, f)
        {

        }
    }
}
