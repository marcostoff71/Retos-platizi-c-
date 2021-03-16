using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1y0
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder numerosConsola = new StringBuilder();
            int longitud;
            string num1_0 = "01";
            Random aleatorio = new Random();

            Console.WriteLine("Dame la longitud");
            longitud = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < longitud; i++)
            {
                numerosConsola.Append(num1_0[aleatorio.Next(2)]);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(numerosConsola);
        }
    }
}
