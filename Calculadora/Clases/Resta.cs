using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class Resta
    {
        public decimal Restar(string[] num1)
        {
            decimal restar =0;
            for (int i = 0; i < num1.Length; i++)
            {
                if (!string.IsNullOrEmpty(num1[i]))
                {
                    if(restar>0)
                        restar=restar- Convert.ToDecimal (num1[i]);
                    else
                        restar = Convert.ToDecimal(num1[i]);
                }
            }   
            return restar;
        }
    }
}
