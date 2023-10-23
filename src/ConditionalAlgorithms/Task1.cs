using System.Transactions;
using System;

namespace ConditionalAlgorithms;

public class Task1
{
    public (double a, double b) Calculate(double x, double y, double z)
    {
        
        if (x == 0)
            Console.WriteLine("Error x");
        if (y == 0)
            Console.WriteLine("Error y");
        if (z == 0)
            Console.WriteLine("Error z");
        double a = (x * y * z) / Math.Sin(2 * x * y * z);
        double b = 1 / (Math.Pow(a, 4) * Math.Sqrt(Math.Log(a + x * y)));
        return (a, b);
    }
}