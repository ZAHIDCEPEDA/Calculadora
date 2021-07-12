using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class Division
    {
        public decimal Dividir(string[] num1)
        {
            decimal dividir = 0;
            for (int i = 0; i < num1.Length; i++)
            {
                if (!string.IsNullOrEmpty(num1[i]))
                {
                    if (dividir > 0)
                        dividir = dividir / Convert.ToDecimal(num1[i]);
                    else
                        dividir = Convert.ToInt32(num1[i]);
                }
            }
            return dividir;
        }
    }
}
