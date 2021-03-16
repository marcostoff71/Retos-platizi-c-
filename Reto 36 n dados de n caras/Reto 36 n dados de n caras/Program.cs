using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_36_n_dados_de_n_caras
{
    class Program
    {
        /*
         Crea un programa que te permite simular el tiro de n dados de n caras
        */
        static void Main(string[] args)
        {
            int numDados, numCaras;

            Console.Write("Cuantos datos deseas tirar: ");
            numDados = int.Parse(Console.ReadLine().Trim());
            Console.Write("Cuantos datos deseas tirar: ");
            numCaras = int.Parse(Console.ReadLine().Trim());


            int[] dados = new int[numDados];//creamos el array

            Random rdn = new Random();

            for (int i = 0; i < dados.Length; i++)
            {
                dados[i] = rdn.Next(1, numCaras);
            }
            for (int i = 0; i < dados.Length; i++)
            {
                Console.WriteLine("Dado {0} Cara {1}", i + 1, dados[i]);
            }

        }
    }
}
