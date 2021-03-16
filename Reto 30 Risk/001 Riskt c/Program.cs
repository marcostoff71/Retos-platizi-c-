using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Riskt_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            int[] atacante1 = new int[3];
            int[]atacante2= new int[2];
            
            for(int i = 0; i < 3; i++)
            {
                atacante1[i] = rdn.Next(1, 6);
            }
            for (int i = 0; i < 2; i++)
            {
                atacante2[i] = rdn.Next(1, 6);
            }
            Console.Write("Atante 1: [");
            for (int i = 0; i < 3; i++)
            {
                if (i != 2)
                {
                    Console.Write($"{atacante1[i]} , ");
                }
                else
                {
                    Console.Write($"{atacante1[i]}");
                }
            }
            Console.WriteLine("]");

            Console.Write("Atante 2: [");
            for (int i = 0; i < 2; i++)
            {
                if (i != 1)
                {
                    Console.Write($"{atacante2[i]} , ");
                }
                else
                {
                    Console.Write($"{atacante2[i]}");
                }
            }
            Console.WriteLine("]");







        }
    }
}
