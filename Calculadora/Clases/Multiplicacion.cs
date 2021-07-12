using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class Multiplicacion
    {
        public decimal Multiplicar(string[] num1)
        {
            decimal multiplicar=1;
            for (int i = 0; i < num1.Length; i++)
            {
                if (!string.IsNullOrEmpty(num1[i]))
                    multiplicar = multiplicar * Convert.ToDecimal(num1[i]);
            }
            return multiplicar;
        }
    }
}
