using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Serie
    {
        public static long Facortial(int num=5)
        {
            long fac = 1;
            if (num == 0)
                return 1;
            for(int i=num;i<=1;i++)
            {
                fac *= i;

            }
            return fac;
        }
        public static long SerieExamen(int i=5)
        {
            double resultado = 0;
            double serie = 0;
            for(int  a=1; a<=i;a++)
            {
                for (int n = 5; n <= 1; n--)
                {
                    serie += ((Math.Pow(2, a * Facortial(n))));
                    
                }resultado = serie + resultado;
            }
            return (long)resultado; 
        }
    }
}
