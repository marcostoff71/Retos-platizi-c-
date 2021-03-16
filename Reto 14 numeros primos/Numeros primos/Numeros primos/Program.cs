using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionNum, numPrimos=0;
            ArrayList numPrimTotal = new ArrayList();
            //pedimos el numero de veces 
            do
            {
                opcionNum = ValidaInt("Dame el limitel de valor de numero: ");
                if (opcionNum < 2)
                {
                    Console.WriteLine("El numero debe sermayor que 1");
                }
            } while (opcionNum < 2);

            for(int i = 2; i <= opcionNum; i++)
            {
                if (i == 2)
                {
                    numPrimos++;
                    numPrimTotal.Add(i);
                }
                if ((i % 2) == 1 )
                {
                    numPrimos++;
                    numPrimTotal.Add(i);
                    
                }
            }
            
            Console.Write("El numero {0} tiene {1} numeros primos y son: ", opcionNum, numPrimos);
            foreach (int i in numPrimTotal)
            {
                Console.Write("{0} ",i);
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
    }
}
