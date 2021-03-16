using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_morse
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            CMorse morse1 = new CMorse();
            Console.Beep();
            do
            {
                Console.WriteLine("\tTraductor morse");
                Console.WriteLine("1. Ingles a morse");
                Console.WriteLine("2. Morse a Ingles");
                Console.WriteLine("3. Salir");
                do//validador de opcion escoguida
                {
                    opcion = ValidaInt("Escogue una opcion: ");
                    if (opcion < 1 || opcion > 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tOpcion fuera de rango");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                } while (opcion < 1 || opcion > 3);

                switch (opcion)
                {
                    case 1:
                        morse1.Iniciar();
                        morse1.PedirPalabra();
                        morse1.traducir();
                        break;
                    case 2:
                        morse1.Iniciar();
                        morse1.PedirPalabra();
                        morse1.traducirMorse();
                        break;
                }
                Console.WriteLine("Presiona un tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 3);
        }
        static int ValidaInt(string mensaje)
        {
            bool valor;
            int numfinal;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numfinal);
               
            } while (!valor);

            return numfinal;
        }
    }
}
