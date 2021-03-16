using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] atacante = new int[3];
            int[] defensor = new int[2];

            tirarDados(atacante, defensor);
            bubbleSort(atacante, defensor);
            imprimirDados(atacante, defensor);
            juego(atacante, defensor);
        }
        static void juego(int[] atacante, int[] defensor)
        {
            for (int i = 0; i < 2; i++)
            {
                if (atacante[i] > defensor[i])
                {
                    Console.WriteLine("atacante gana ronda " + (i + 1));
                }
                else if(atacante[i] < defensor[i])
                {
                    Console.WriteLine("defensor gana ronda " + (i + 1));
                }
                else
                {
                    Console.WriteLine("Empate en la ronda " + (i + 1));
                }
            }
        }
        static void tirarDados(int[] atacante, int[] defensor)
        {
            for (int i = 0; i < atacante.Length; i++)
            {
                Random random = new Random();
                int numero = random.Next(10);
                atacante[i] = numero;
            }
            for (int i = 0; i < defensor.Length; i++)
            {
                Random rd = new Random();
                int numero2 = rd.Next(10);
                defensor[i] = numero2;
            }
        }

        static void bubbleSort(int[] atacante, int[] defensor)
        {
            bool cambio = true;
            while (cambio)
            {
                cambio = false;
                for (int i = 1; i < atacante.Length ; i++)
                {
                    for(int j = 0; j < atacante.Length - i; j++)
                    {

                    if (atacante[j] > atacante[j + 1])
                    {
                        int aux = atacante[j];
                        atacante[j] = atacante[j + 1];
                        atacante[j + 1] = aux;
                        cambio = true;
                    }
                    }
                }
            }
            for (int i = 0; i < (defensor.Length) - 1; i++)
            {
                if (defensor[i] < defensor[i + 1])
                {
                    int aux = defensor[i];
                    defensor[i] = defensor[i + 1];
                    defensor[i + 1] = aux;
                }
            }

        }

        static void imprimirDados(int[] atacante, int[] defensor)
        {
            string linea = "atacante= ";
            for (int i = 0; i < atacante.Length; i++)
            {
                linea += atacante[i] + " ";
            }
            Console.WriteLine(linea);
            string linea2 = "defensor= ";
            for (int i = 0; i < defensor.Length; i++)
            {
                linea2 += defensor[i] + " ";
            }
            Console.WriteLine(linea2);
        }
    }
}

