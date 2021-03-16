using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace OrdenandoAndo_003
{
    class COrdeamientoNom
    {
        Stopwatch tiempo = new Stopwatch();
        List<string> nombres;
        public void IngresarNombre()
        {
            
            nombres = new List<string>();
            using (StreamReader sr = new StreamReader("nombres.csv"))
            {
                while (sr.ReadLine() != null)
                {
                    nombres.Add(sr.ReadLine());
                }
            }
        }
        public override string ToString()
        {
            string info="";
            foreach(string nom in nombres)
            {
                info += nom + "\n";
            }

            return info;
        }
        public void BubbleSort()//bubble sort 
        {
            tiempo.Start();
            //empezamos con el primer recorrido
            for(int i = 1; i < nombres.Count; i++)
            {
                //restamos i para ir recorriendo el mayor numero
                for(int j = 0; j < nombres.Count - i; j++)
                {
                    //hacemos la comparasion y si se cumple 
                    //hacemos un swap para que vaya subiendo 
                    //el numero mayor
                    if (nombres[j].CompareTo(nombres[j+1])==1)
                    {
                        string aux;
                        aux = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = aux;
                    }
                }
            }
            tiempo.Stop();
            Console.WriteLine("Tiempo transcurrido ordenamiento con bubble sort: {0}ms", tiempo.Elapsed.TotalMilliseconds);
            tiempo.Reset();
        }
        public void InsertionSort()//insertion sort
        {
            tiempo.Start();

            int cantidad;
            cantidad = nombres.Count;
            int postAgujero;
            //for(int i = 1; i < cantidad; i++)
            //{
            //    postAgujero = i;

            //    while (postAgujero > 0 && nombres[postAgujero - 1].CompareTo(nombres[postAgujero]) == 1)
            //    {
            //        string temp;
            //        temp = nombres[postAgujero];
            //        nombres[postAgujero] = nombres[postAgujero - 1];
            //        nombres[postAgujero - 1] = temp;

            //        postAgujero--;
            //    }
            //}

            string dato;
            for (int i = 1; i < cantidad; i++)
            {
                postAgujero = i;
                dato = nombres[i];
                while (postAgujero > 0 && nombres[postAgujero - 1].CompareTo(dato) == 1)
                {
                    nombres[postAgujero] = nombres[postAgujero - 1];
                    postAgujero--;
                }

                nombres[postAgujero] = dato;
            }

            tiempo.Stop();
            Console.WriteLine("Tiempo transcurrido ordenamiento con Insertion sort: {0}ms", tiempo.Elapsed.TotalMilliseconds);
            tiempo.Reset();
        }
        public void SelectionSort()//SelectionSort
        {
            tiempo.Start();
            int imIn;

            for(int i = 0; i < nombres.Count; i++)
            {
                imIn = i;
                for(int j = i + 1; j < nombres.Count; j++)
                {
                    if (nombres[imIn].CompareTo(nombres[j]) == 1)
                    {
                        imIn = j;
                    }
                }
                string aux;
                aux = nombres[i];
                nombres[i] = nombres[imIn];
                nombres[imIn] = aux;
            }

            tiempo.Stop();
            Console.WriteLine("Tiempo transcurrido ordenamiento con Selection sort: {0}ms", tiempo.Elapsed.TotalMilliseconds);
            tiempo.Reset();
        }

    }
}
