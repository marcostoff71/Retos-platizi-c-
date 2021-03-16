using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ordenando_ando_002
{
    class Program
    {
        static void Main(string[] args)
        {
            COrdenando orde1 = new COrdenando();
            orde1.pedirArchivos();
            Console.WriteLine(orde1.ToString());
            Console.WriteLine("----------------------");
            orde1.BubbleSort();
            Console.WriteLine(orde1.ToString());



            COrdenando orde2 = new COrdenando();
            orde2.pedirArchivos();
            Console.WriteLine("-------------------------");
            orde2.InsertionSort();
            Console.WriteLine(orde2.ToString());
            
        }
    }
    class COrdenando
    {
        List<string> nombres= new List<string>();

        public void pedirArchivos()
        {
            using(StreamReader sr = new StreamReader("nombres.csv"))
            {
                while (sr.EndOfStream == false)
                {
                    nombres.Add(sr.ReadLine());
                }
            }
        }
        public void BubbleSort()
        {
            for(int i = 1; i < nombres.Count; i++)
            {
                for(int j = 0; j < nombres.Count - i; j++)
                {
                    string aux;
                    if (nombres[j].CompareTo(nombres[j + 1]) == 1)
                    {
                        aux = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = aux;
                    }
                }
            }
        }
        public void InsertionSort()
        {
            string dato;
            int postAgujero;
            for(int i = 1; i < nombres.Count; i++)
            {
                dato = nombres[i];
                postAgujero = i;
                while (postAgujero > 0 && nombres[postAgujero-1].CompareTo(dato) == 1)
                {
                    nombres[postAgujero] = nombres[postAgujero-1];
                    postAgujero--;

                }

                nombres[postAgujero] = dato;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string nom in nombres)
            {
                sb.AppendLine(nom);
            }

            return sb.ToString();
        }

    }
}
