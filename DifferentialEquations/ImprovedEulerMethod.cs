using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentialEquations
{
    class ImprovedEulerMethod : NumericalMethod
    {
        public override double GetNextY(double xi, double yi, Function f)
        {
            double k1 = f.F(xi, yi);
            double k2 = f.F(xi + h, yi + h * k1);
            return yi + h / 2 * (k1 + k2);
        }

        public ImprovedEulerMethod(int N, double x0, double y0, double X, Function f) : base(N, x0, y0, X, f)
        {

        }
    }
}
