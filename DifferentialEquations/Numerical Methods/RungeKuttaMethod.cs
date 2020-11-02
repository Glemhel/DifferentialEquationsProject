namespace DifferentialEquations
{
    /*
    * Runge Kutta Method numerical method for
    * solveing differential equation initial value problem
    */
    public class RungeKuttaMethod : NumericalMethod
    {
        /*
         * Method's own implementation of approximation based on previous values
         */
        public override double GetNextY(double xi, double yi, double h, Function f)
        {
            double k1 = f.F(xi, yi);
            double k2 = f.F(xi + h / 2, yi + k1 * h / 2);
            double k3 = f.F(xi + h / 2, yi + k2 * h / 2);
            double k4 = f.F(xi + h, yi + h * k3);
            return yi + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
        }

        /* Uses base constructor for NumericalMethod
         */
        public RungeKuttaMethod(int N, double x0, double y0, double X, Function f) : base(N, x0, y0, X, f)
        {

        }
    }
}
