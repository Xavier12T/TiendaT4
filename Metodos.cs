using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Metodos
    {
        public static int fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
        public static double factorial(double n)
        {
            if (n == 0 || n == 1) return 1;
            return n * factorial(n - 1);
        }
        public static int potencia(int n, int potenc)
        {
            if (potenc == 0) return 1;
            else
                return n * potencia(n, potenc - 1);
        }




    }
}
