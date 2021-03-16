using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenar_un_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //varbles mecesariaso
            string textoUsuario;
            string textoUsuarioOrdenado;
            //pedimos los datos al uduario
            Console.Write("Dame un texto y lo ordenare: ");
            //lo asigamos 
            textoUsuario = Console.ReadLine();
            //llamamos al metodo
            textoUsuarioOrdenado = OrdenaString(textoUsuario);
            //mostramos en consola
            Console.WriteLine(textoUsuarioOrdenado);

            char[] letras = textoUsuarioOrdenado.ToCharArray();
            Array.Reverse(letras);
            string hola = new string(letras);

            Console.WriteLine(new string(letras));
            
        }
        static string OrdenaString(string ingresado)
        {
            char[] ordenar;
            ordenar = ingresado.ToCharArray();
            
            Array.Sort(ordenar);
            

            return new string(ordenar);
        }
    }
}
