using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciW
{
    public class Fibonacci
    {
        public long calcular(int posicion)
        {
            int fib ;
        
            if (posicion == 1)
                return 0;

            if (posicion == 2 || posicion == 3) {
                 return 1;
            } 
             
            int a = 1;
            int b = 1;
            int resutado = -1;
            for (int i = 3; i <= posicion -1 ; i++)
            {
                resutado = a + b;
                a = b;
                b = resutado;
            }

            return resutado;
        }

    }
}
