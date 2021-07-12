using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class Suma
    {
        public decimal Sumar(string[] num1)
        {
            decimal sumar = 0;
            for(int i=0; i<num1.Length; i++)
            {
                if (!string.IsNullOrEmpty(num1[i])) 
                    sumar = sumar + Convert.ToDecimal(num1[i]);
            }
            return sumar;
        }

    }
}
