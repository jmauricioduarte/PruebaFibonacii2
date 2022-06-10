using System;

namespace FibonacciW
{
    class Startup
    {
        static void Main()
        {
             
            Fibonacci a = new Fibonacci();
            Console.WriteLine(a.calcular(5));
        }
    }
}
