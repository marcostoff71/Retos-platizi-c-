using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volumenes_cilindro_esfera
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int opcion;
            Volumenes calculaVolumen = new Volumenes();
            do
            {
                Console.WriteLine("\tVolumen");
                Console.WriteLine("1. Calcula el volumen de un cubo");
                Console.WriteLine("2. Calcula el volumen de un cilindro");
                Console.WriteLine("3. Calcula el volumen de una esfera");
                Console.WriteLine("4. Salir");
                do
                {
                    opcion = ValidaInt("Escogue una opcion: ");
                } while (opcion < 1 || opcion > 4);
                if (opcion == 1) 
                {
                    calculaVolumen.VolumenCubo();
                }else if (opcion == 2)
                {
                    calculaVolumen.VolumenCilindro();
                }else if (opcion == 3)
                {
                    calculaVolumen.VolumenEsfera();
                }

            } while (opcion!=4);

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
