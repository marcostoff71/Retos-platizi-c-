using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenar_numeros_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ordenar ordena1 = new Ordenar();
            //ordena1.OrdenarNum();

            char[] dsa = { 'h', 'o', 'l', 'a' };
            string hoa =new string(dsa);
            Console.WriteLine(new string(dsa));
            Console.WriteLine(hoa);
        }
    }
    class Ordenar
    {
        public void OrdenarNum()
        {
            string mensaje,ordenado;
            int validador;
            bool valor = false;
            do
            {
                Console.Write("Dame los numero para ordenarlos: ");
                mensaje = Console.ReadLine();
                valor = int.TryParse(mensaje, out validador);
            } while (valor == false);

            char[] ordenar;
            ordenar = mensaje.ToCharArray();
            int[] nums = new int[] { 1, 23, 5, 76, 8 };
            Array.Sort(mensaje.ToArray());
            Console.WriteLine(mensaje);
             Array.Sort(ordenar);

            Console.WriteLine("Los numeros ordenador de menor a mayor son");
            ordenado = new string(ordenar);
            Console.WriteLine(ordenado);

            Array.Reverse(ordenar);
            Console.WriteLine("Los numero ordenador de mayor a menor son");
            ordenado = new string(ordenar);
            Console.WriteLine(ordenado);
            
        }
    }
}
