namespace DifferentialEquations
{
    /*
     * Improved Euler Method numerical method for
     * solveing differential equation initial value problem
     */
    class ImprovedEulerMethod : NumericalMethod
    {
        /*
         * Method's own implementation of approximation based on previous values
         */
        public override double GetNextY(double xi, double yi, double h, Function f)
        {
            double k1 = f.F(xi, yi);
            double k2 = f.F(xi + h, yi + h * k1);
            return yi + h / 2 * (k1 + k2);
        }

        /* Uses base constructor for NumericalMethod
         */
        public ImprovedEulerMethod(int N, double x0, double y0, double X, Function f) : base(N, x0, y0, X, f)
        {

        }
    }
}
