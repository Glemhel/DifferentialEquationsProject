using System;

namespace DifferentialEquations
{
    /*
     * Implements interface function: my function of
     * the right hand side of the differential equaiton
     */
    public class MyFunction : Function
    {
        public double F(double x, double y)
        {
            return y / x - x * Math.Pow(Math.E, y / x);
        }
    }
}
