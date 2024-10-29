using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WOW
{
    class ConsolePrinter: IPrinter
    {
        public int Skip { get; init; } = 1;
        static void Print(string s)=> Console.WriteLine(s);
        static void PrintSolverIteration(int iter, double residual, double eps)
        {
            if(iter%Skip==0) Console.WriteLine($"\r Iteration: {iter} Residual: {residual} Eps: {eps}");
        }
    }
}