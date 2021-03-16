using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertir_texto_001
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto,textoInvertido;
            Console.Write("Dame el texto a invertir: ");
            texto = Console.ReadLine();
            textoInvertido = Invertir(texto);
            Console.WriteLine(textoInvertido);
            Console.ReadLine();

        }
        static string Invertir(string mensaje)
        {
            char[] textoInvertido;
            textoInvertido = mensaje.ToCharArray();
            Array.Reverse(textoInvertido);


            return new string(textoInvertido);
        }
    }
}
