using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = new string[] { "sa", "sasa", "sasa" };
            Random aleatorio = new Random();
            Console.WriteLine(palabras[aleatorio.Next(0, 2)]);
            Console.WriteLine(aleatorio.Next(20));
        }
    }
}
