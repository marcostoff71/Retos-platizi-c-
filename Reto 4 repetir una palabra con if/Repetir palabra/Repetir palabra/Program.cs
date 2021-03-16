using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetir_palabra
{
    class Program
    {
        static void Main(string[] args)
        {
            int veces;
            string palabra;
            //pedimos la palabra
            Console.Write("Dame una palabra: ");
            palabra = Console.ReadLine().Trim();
            //pedimos las veces que repetira la palabra
            veces = ValidaNum("Cuantas veces quieres repetir la palabra: ");
            Console.WriteLine(RepetirCadena(palabra, veces));
            while (veces > 0)
            {
                veces--;
                Console.WriteLine(palabra+"While");
            }
            
        }
        static int ValidaNum(string mensaje)
        {
            bool valor = false;
            int numVali=0;
            while (valor == false)
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numVali);
            }

            return numVali;
        }
        static string RepetirCadena(string palabra,int veces)
        {
            if (veces == 1)
            {
                return palabra;
            }
            else
            {
                veces--;
                return palabra = palabra + " " + RepetirCadena(palabra, veces);
            }
        }
    }
}
