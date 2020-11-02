namespace DifferentialEquations
{
    /*
     * Abstract class of the exact solution of the differential equation
     * exact solution function is the function to b implemented
     */
    public abstract class ExactSolution : Grid
    {
        // abstract function - the solution function itself
        public abstract double exactSolutionFunction(double x, double x0, double y0);

        // constructor - fills the y coordinates based on the solution function
        public ExactSolution(int N, double x0, double y0, double X) : base(N, x0, X)
        {
            for (int i = 0; i <= N; i++)
            {
                y[i] = exactSolutionFunction(x[i], x0, y0);
            }
        }
    }
}
