using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_39_Te_conviene_esta_apuesta
{
    class Program
    {

        /*
         Imagina que una persona te dice que debes adivinar un número al azar entre 0 y 100. Si lo adivinas en la primera oportunidad te da 4 usd, en la segunda 3 usd, en la tercera 2 usd, en la cuarta 1 usd, en la quinta 0 usd y a partir de la sexta tú le pagas 1 usd, en la séptima 2 usd, etc.

            ¿Debería jugar este juego?

            Tip: piensa en búsqueda binaria y cuánto te tardarías en promedio en encontrar el número aleatorio.
         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Adivina el numero");
            Console.WriteLine("Instrucciones: Imagina que una persona te dice que debes adivinar un número al azar entre 0 y 100. Si lo adivinas en la primera oportunidad te da 4 usd, en la segunda 3 usd, en la tercera 2 usd, en la cuarta 1 usd, en la quinta 0 usd y a partir de la sexta tú le pagas 1 usd, en la séptima 2 usd, etc.");
            int numEn, contVeces=0,numUs;
            Random rnd = new Random();
            numEn = rnd.Next(0, 100);
            Console.WriteLine(numEn);
            do
            {
                Console.WriteLine("Dame el numero: ");
                numUs = int.Parse(Console.ReadLine().Trim());
                contVeces++;
                if (numEn == numUs)
                {
                    break;
                }
                else
                {
                    
                }
            } while (numEn != numUs);

            int pago = 0;
            int dine = 4;
            int dinePagar = 0;
            for(int i = 0; i < contVeces; i++)
            {
                if (i <= 5)
                {
                    pago = dine - i;
                }
                else
                {
                    dinePagar++;
                    pago = dinePagar;
                }
            }
            Console.WriteLine(pago);
        }
    }
}
