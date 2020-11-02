namespace DifferentialEquations
{
    // Helper class for the function of two variables - right hand side of the 
    // Differential equation
    public interface Function
    {
        double F(double x, double y);
    }
}
