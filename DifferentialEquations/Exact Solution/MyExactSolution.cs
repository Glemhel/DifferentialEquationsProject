using System;

namespace DifferentialEquations
{
    /*
     * Exact solution for the differential equation one wants to solve
     */
    class MyExactSolution : ExactSolution
    {
        /*
         * Implementation of the exactSolutionFunction abstarct function
         * Here we provide the exact solution function for the DE
         */

        public override double exactSolutionFunction(double x, double x0, double y0)
        {
            return -x * Math.Log(x + Math.Exp(-y0 / x0) - x0);
        }

        /*
         * Constuctor uses base constructor of ExactSolution, where y values are filled
         */
        public MyExactSolution(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {

        }
    }
}
