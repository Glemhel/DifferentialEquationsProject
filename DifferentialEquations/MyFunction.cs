using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentialEquations
{
    public class MyFunction : Function
    {
        public double F(double x, double y)
        {
            return y / x - x * Math.Pow(Math.E, y / x);
        }   
    }
}
