using System.Runtime.InteropServices;

namespace WOW
{
    public static class VectorOperato0rs
    {
        public static double Dot(this Span<double> a, double x)
    }
    public class JacobiSolver:ISlaeSolver
    {
        public int MaxIter{ get; init; } = 1000;
        public double Eps{ get; init; } = 1e-10;
        public void Solve(ISLAE slae, Span<double> vector, Span<double> res)
        {
            var work = new double[slae.RightPart,Length];
            Console.WriteLine("Begin Jacobi solver");
            for (int iter = 0; iter  < MaxIter; iter++ )
            {
                slae.Residual(solution);
                printer.PrintSolverIteration(iter, residual,Eps);
            }
        }
        printer.Print("\n Finished Jacobi solver");
    }
}