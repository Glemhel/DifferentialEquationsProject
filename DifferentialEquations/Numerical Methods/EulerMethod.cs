namespace DifferentialEquations
{
    class EulerMethod : NumericalMethod
    {
        /*
         * Method's own implementation of recalculation function
         */
        public override double GetNextY(double xi, double yi, double h, Function f)
        {
            return yi + h * f.F(xi, yi);
        }

        // uses base constructor
        public EulerMethod(int N, double x0, double y0, double X, Function f) : base(N, x0, y0, X, f)
        {

        }
    }
}
