using System;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace Reto_26_27_28_Ordenando_ando
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ArrayList nombres = new ArrayList();
            StreamReader leerArchivo = new StreamReader("archivo.csv");
            
            while (!leerArchivo.EndOfStream)
            {
                string nombre = leerArchivo.ReadLine();
                nombres.Add(nombre);
            }
            leerArchivo.Close();
            string linea = "";
            foreach (string i in nombres)
            {
                linea += i + ", ";
            }
            Console.WriteLine("Arreglo original: ");
            Console.WriteLine(linea);
            Console.WriteLine("\n\n\n\n");
            bubbleSort(nombres);
            Console.WriteLine("\n\n\n\n");
            InsertionSort(nombres);

        }

        public static void bubbleSort(ArrayList nombres)
        {
            Boolean cambio = false;
            Stopwatch tiempo = new Stopwatch();
            tiempo.Start();
            do
            {
                cambio = false;
                for (int i = 0; i < (nombres.Count - 1); i++)
                {
                    string auxiliar1 = nombres[i].ToString();
                    string auxiliar2 = nombres[i + 1].ToString();
                    if (auxiliar1.CompareTo(auxiliar2) == 1)
                    {
                        nombres[i] = auxiliar2;
                        nombres[i + 1] = auxiliar1;
                        cambio = true;
                    }
                }
            } while (cambio);
            tiempo.Stop();
            string linea = "";
            foreach (var i in nombres)
            {
                linea += i + ", ";
            }
            Console.WriteLine("Arreglo ordenado alfabeticamente con Bubble Sort: ");
            Console.WriteLine(linea);
            Console.WriteLine("tiempo transcurrido: " + tiempo.Elapsed.TotalMilliseconds + " ms");
            Console.WriteLine("\n\n\n\n");


        }

        public static void InsertionSort(ArrayList nombres)
        {
            Stopwatch tiempo = new Stopwatch();
            tiempo.Start();
            for (int i = 1; i < nombres.Count; i++)
            {
                string valorActual = nombres[i].ToString();
                int j = i - 1;

                while (j >= 0 && (nombres[j].ToString().CompareTo(valorActual) == 1))
                {
                    nombres[j + 1] = nombres[j];
                    j--;
                }
                nombres[j + 1] = valorActual;
            }
            tiempo.Stop();
            string linea = "";
            foreach (var i in nombres)
            {
                linea += i + ", ";
            }
            Console.WriteLine("Arreglo ordenado alfabeticamente con Insertion Sort: ");
            Console.WriteLine(linea);
            Console.WriteLine("tiempo transcurrido: " + tiempo.Elapsed.TotalMilliseconds + " ms");
            Console.WriteLine("\n\n\n\n");
        }
    }
}