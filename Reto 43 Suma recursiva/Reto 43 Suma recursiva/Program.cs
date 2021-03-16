using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_43_Suma_recursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=sumaRecursiva();
            Console.WriteLine("La suma es {0}", num);
        }
        static int sumaRecursiva(int num=0)
        {
           
            Console.WriteLine("Dame un numero: ");
            num = int.Parse(Console.ReadLine());
            int suma = 0;
            if (num == 0)
            {
                return num;
            }
            else
            {
                suma += num;
                return suma+=sumaRecursiva();
            }

        }
    }
}
