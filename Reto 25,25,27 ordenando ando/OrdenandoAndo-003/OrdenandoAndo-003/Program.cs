using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoAndo_003
{
    class Program
    {
        static void Main(string[] args)
        {
            COrdeamientoNom[] ordenamineto = new COrdeamientoNom[3];
            ordenamineto[0] = new COrdeamientoNom();
            ordenamineto[0].IngresarNombre();
            ordenamineto[0].BubbleSort();
            Console.WriteLine(ordenamineto[0].ToString());

            ordenamineto[1] = new COrdeamientoNom();
            ordenamineto[1].IngresarNombre();
            ordenamineto[1].InsertionSort();
            Console.WriteLine(ordenamineto[0].ToString());


            ordenamineto[2] = new COrdeamientoNom();
            ordenamineto[2].IngresarNombre();
            ordenamineto[2].SelectionSort();
            Console.WriteLine(ordenamineto[0].ToString());


        }
    }
}
