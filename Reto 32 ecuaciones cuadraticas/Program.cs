using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_32_ecuaciones_cuadraticas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ecuaciones de segundo grado

             */
            int a, b, c;
            Console.WriteLine("\tEcuaciones de segudno grado");
            a = ValidaINt("Dame el valor de a: ");
            b = ValidaINt("Dame el valor de b: ");
            c = ValidaINt("Dame el valor de c: ");

            double resultado;
            resultado = (-b + Math.Sqrt(Math.Pow(b, 2) -4 * a * c)) / (2 * a);
            //resultado = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;

            Console.WriteLine(resultado);











            //int hola;
            //string nombre = "luisa";
            //nombre.Reverse();
            //int num=ValidaINt("Dame un numero: ");

            //for(int i = 1; i <= num.ToString().Length; i++)
            //{
            //    Console.WriteLine(num.ToString().Substring(num.ToString().Length-i));
            //}
        }
        static int ValidaINt(string mensaje)
        {
            bool valor;
            int num;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out num);
            } while (!valor);

            return num;
        }
    }
}
