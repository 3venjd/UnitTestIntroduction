using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        public static int Sum(int N1, int N2)
        {
            return N1 + N2;
        }

        public static int Substract(int N1, int N2)
        {
            return N1 - N2;
        }

        public static int Multiplication(int N1, int N2)
        {
            return N1 * N2;
        }

        public static int Division(int N1, int N2)
        {
            return N1 / N2;
        }
    }
}
