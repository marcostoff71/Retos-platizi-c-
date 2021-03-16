using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_secreto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Numero secreto";
            Random numAleatorio1 = new Random();
            int numSecreto, numUsuario,opcion;
            do
            {
                Console.WriteLine("\tNumero secreto");
                Console.WriteLine("1. Iniciar juego");
                Console.WriteLine("2. Salir ");
                do
                {
                    opcion = ValidaInt("Escogue una opcion: ");
                    if (opcion < 1 || opcion > 2)
                    {
                        Console.WriteLine("Opcion incorreta intenta de nuevo");
                    }
                } while (opcion < 1 || opcion > 2);
                if (opcion == 1)
                {
                    numSecreto = numAleatorio1.Next(100);
                    do
                    {
                        numUsuario = ValidaInt("Dame el numero secreto; ");
                        if (numSecreto < numUsuario)
                        {
                            Console.WriteLine("\t\tEl numero es menor");
                        }
                        else if (numSecreto > numUsuario)
                        {
                            Console.WriteLine("\t\tEl numero es mayor");
                        }
                        else
                        {
                            Console.WriteLine("\t\t\t¡¡¡Ganaste!!!!");
                            Console.Beep();
                            
                            Console.Clear();
                        }
                        
                    } while (numUsuario != numSecreto);
                }
            } while (opcion != 2);
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.Write("Hola");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Holaaaaaa");
            Console.ForegroundColor =ConsoleColor.Gray;

            Console.WriteLine("Mundo saaaaaaaaaaaaaaaaa");
            Console.ReadKey();

            
            
            


        }
        static int ValidaInt(string mensaje)
        {
            bool valor = false;
            int numFinal=0;
            while (valor == false)
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            }
            return numFinal;
        }
    }
}
