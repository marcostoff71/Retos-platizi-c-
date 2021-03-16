using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_35_tiro_de_n_dados_de_6_caras
{
    class Program
    {
        /*
         Crea un programa que te permita simular el tiro de n dados de 6 caras
        */
        static void Main(string[] args)
        {
            int num = 0;
            string n;
            do
            {
                Console.Write("¿Cuantos dados deseas tirar?:  ");
                n = Console.ReadLine();

            }while(!int.TryParse(n, out num));

            Random rdn = new Random(324343);
            
            int[] dados = new int[num];
            for(int i = 0; i < num; i++)
            {
                dados[i] = rdn.Next(1, 6);
            }
            for (int i = 0;i < dados.Length; i++)
            {
                Console.WriteLine("Dado: {0} Cara: {1}",i + 1, dados[i]);
            }
        }
    }
}
