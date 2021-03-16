using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_33_fibonacci_de_10000
{
    class Program
    {
        static void Main(string[] args)
        {


            int num = funcionp(2, 3);
            Console.WriteLine(num);
        }
        static int funcionp(int m, int n)
        {

            if (n == 0)
            {

                return 1;
            }

            else
            {

                return m * funcionp(m, n - 1);

            }

        } //Cierre del método

    }
    class Fibo
    {
        public decimal potencia(int num,int po)
        {
            if (po == 0)
            {
                return 1;
            }
            else
            {
                return num * potencia(num , po - 1);
            }
        }
        public decimal fibo(decimal n1)
        {
            if (n1 <= 1)
            {
                return 1;
            }
            else
            {
                return fibo(n1 - 1) + fibo(n1 - 2);
            }
        }
    }
}
