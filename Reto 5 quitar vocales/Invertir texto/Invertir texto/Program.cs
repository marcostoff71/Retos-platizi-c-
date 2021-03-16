using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertir_texto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.Write("Dame un texto y lo invertire: ");
            texto = Console.ReadLine();
            texto = InvertirString(texto);
            Console.WriteLine(texto);


        }
        static string InvertirString(string texto)
        {
            //convertimos a caracter
            char[] textoinvertido;
            textoinvertido= texto.ToCharArray();
            Array.Reverse(textoinvertido);
            //convertimos de nuevo a string
            string regresar = new string(textoinvertido);
            //return new string(textoinvertido);
            return regresar;
        }
    }
}

