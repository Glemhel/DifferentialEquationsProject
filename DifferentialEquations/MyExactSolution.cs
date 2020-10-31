using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentialEquations
{
    class MyExactSolution : ExactSolution
    {
        public override double exactSolutionFunction(double x, double x0, double y0)
        {
            return -x * Math.Log(x + Math.Exp(-y0 / x0) - x0);
        }

        public MyExactSolution(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {

        }
    }
}
