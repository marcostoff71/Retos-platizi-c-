using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,factorial=1;
            Console.WriteLine("\t\tCalcula el factorial");
            num = ValidaInt("Dame un numero: ");
            for(int i = num; i >= 1; i--)
            {
                factorial *= i;
                Console.WriteLine(factorial);
            }
        }
        static int ValidaInt(string mensaje)
        {
            bool valor;
            int numFinal;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (valor == false);
            return numFinal;
        }
    }
}
