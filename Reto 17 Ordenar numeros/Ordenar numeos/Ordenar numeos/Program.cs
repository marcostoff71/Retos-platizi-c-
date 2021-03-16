using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenar_numeos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Random aleatorio = new Random();
            int numLongitud;
            int[] numerosAleatorio;
            numLongitud = ValidaInt("Dame la longitud del array: ");
            numerosAleatorio = new int[numLongitud];

            for(int i = 0; i < numLongitud; i++)
            {
                numerosAleatorio[i] = aleatorio.Next(100);
            }

            Array.Sort(numerosAleatorio);
            Console.WriteLine("Los numeros ordenados de menor a mayor");
            foreach(int numero in numerosAleatorio)
            {
                Console.Write("{0} ", numero);
            }
            Console.WriteLine();

            Array.Reverse(numerosAleatorio);
            Console.WriteLine("Los numeros ordenador de mayor a menor");
            foreach(int numero in numerosAleatorio)
            {

                Console.Write("{0} ", numero);
            }
            Console.WriteLine();
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
        public void sasad()
        {

        }
    }
}
