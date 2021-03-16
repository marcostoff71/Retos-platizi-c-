
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mememoria_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un código que te muestre 4 caracteres entre los siguientes de forma aleatoria: "#$%()/&
            string caracteres = "\"#$%()/&";
            string final1 = "";
            StringBuilder resultado = new  StringBuilder ();
            Random aleatorio = new Random();

            for(int i = 0; i < 4; i++)
            {
                final1 = final1 + caracteres[aleatorio.Next(caracteres.Length)];
                resultado.Append(caracteres[aleatorio.Next(caracteres.Length)]);

            }

            Console.WriteLine(resultado);
            Console.WriteLine(final1);
            //Lleva un registro del Orden en el que aparecieron los caracteres
            //memori parte 2
            Console.WriteLine("Lleva un registro del Orden en el que aparecieron los caracteres");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Caracter random {0}: {1}",i+1,caracteres[aleatorio.Next(caracteres.Length)]);
            }

            //Dale al usuario un menú para que elija en el orden correcto los caracteres
            //20. Memory (part4)!
            //Crea el código para evaluar si el orden del usuario fue el mismo mostrado por el programa y decirle si ganó o en caso contrario si perdió
            string maquina = "";
            for(int i = 0; i < 4; i++)
            {
                maquina += caracteres[aleatorio.Next(caracteres.Length)];
            }
            int opcion;
            string usuario="";
            do
            {
                Console.WriteLine("Dame el orden de los caracteres");
                Console.WriteLine("1. \"");
                Console.WriteLine("2. #");
                Console.WriteLine("3. $");
                Console.WriteLine("4. %");
                Console.WriteLine("5. (");
                Console.WriteLine("6. )");
                Console.WriteLine("7. /");
                Console.WriteLine("8. &");
                do
                {
                    opcion = ValidaInt("Escogue una opcion: ");

                } while (opcion < 1 || opcion > 8);
                usuario += caracteres[opcion];


            } while (usuario.Length < 4);
            if (usuario == maquina)
            {
                Console.WriteLine("Piensas igual que la maquina ");
                Console.WriteLine(usuario);
            }
            else
            {
                Console.WriteLine("Tu resultado es diferente que el de la mquina");
                Console.WriteLine(maquina);
            }
            

        }
        static int ValidaInt(string mensjae)
        {
            bool valor;
            int numFinal;
            do
            {
                Console.Write(mensjae);
                valor = int.TryParse(Console.ReadLine(), out numFinal);

            } while (valor == false);
            return numFinal;

        }
    }
}
