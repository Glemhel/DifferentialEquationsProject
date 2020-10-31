using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentialEquations
{
    class EulerMethod : NumericalMethod
    {
        public override double GetNextY(double xi, double yi, Function f)
        {
            return yi + h * f.F(xi, yi);
        }

        public EulerMethod(int N, double x0, double y0, double X, Function f) : base(N, x0, y0, X, f)
        {

        }
    }
}
