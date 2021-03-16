using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Risk
{
    class Program
    {
        static void Main(string[] args)
        {
            Rick risk1 = new Rick();
            risk1.Iniciar();
        }
    }
    class Rick
    {
        private int[] atacante;
        private int[] defensor;

        public void Iniciar()
        {
            atacante = new int[3];
            defensor = new int[2];
            Random rdn = new Random();
            //for(int i = 0; i < 3; i++)
            //{
            //    atacante[i] = rdn.Next(1, 6);
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    defensor[i] = rdn.Next(1, 6);
            //}
            for (int i = 0; i < 3; i++)atacante[i] = rdn.Next(1, 6);
            
            for (int i = 0; i < 2; i++)defensor[i] = rdn.Next(1, 6);
            SelectionSort(atacante);
            InsertionSort2(defensor);

            
            int defen=0,ataca=0;
            

            for (int i = 0; i < 2; i++)
            {
                if (atacante[i] > defensor[i])
                {
                    ataca++;
                    
                }
                if (defensor[i] > atacante[i])
                {
                    defen++;

                }
                
            }
         

            if (ataca == 2)
            {
                Console.WriteLine("Atacante: {0}",Mostrar(atacante));
                Console.WriteLine("Defensor: {0}",Mostrar(defensor));
                Console.WriteLine("Defensro pierde 2 {0} es mayor que {1} y {2} es mayor que {3}",atacante[0],defensor[0],atacante[1],defensor[1]);
            }else if (defen == 2)
            {
                Console.WriteLine("Atacantante: {0}", Mostrar(atacante));
                Console.WriteLine("Defensor: {0}", Mostrar(defensor));
                Console.WriteLine("Atacante pierde 2 :::{0} es mayor que {1} y {2} es mayor que {3}", defensor[0], atacante[0], defensor[1], atacante[1]);
            }else if (defen == 1&&ataca==1)
            {
                int j=-1;
                for(int i = 0; i < 2; i++)
                {
                    if (defensor[i] > atacante[i])
                    {
                        j = i;
                    }
                }
                if (j == 0) { 
                Console.WriteLine("Atacantante: {0}", Mostrar(atacante));
                Console.WriteLine("Defensor: {0}", Mostrar(defensor));
                    Console.WriteLine("Atacante pierde 1 :: {0} es mayor que {1} y Defensor pierde 1 {2} es mayor que {3}",defensor[0],atacante[0],atacante[1],defensor[1]);
                }
                else
                {
                    Console.WriteLine("Atacantante: {0}", Mostrar(atacante));
                    Console.WriteLine("Defensor: {0}", Mostrar(defensor));
                    Console.WriteLine("Defensor pierde 1 :: {0} es mayor que {1} y Atacante pierde 1 {2} es mayor que {3}", atacante[0],defensor[0],  defensor[1],atacante[1]);
                }
            }
            else if (defen == 1 || ataca == 1)
            {
                if (defen == 1)
                {
                    Console.WriteLine("Atacante: {0}", Mostrar(atacante));
                    Console.WriteLine("Defensor: {0}", Mostrar(defensor));
                    if (atacante[0] == defensor[0])
                    {
                        Console.WriteLine("Atacacante pierde 1;; {0} es mayor que {1}", defensor[1], atacante[1]);

                    }
                    else if (atacante[1] == defensor[1])
                    {
                        
                        Console.WriteLine("Atacacante pierde 1;; {0} es mayor que {1}", defensor[0], atacante[0]);
                    }
                }
                else
                {
                    Console.WriteLine("Atacante: {0}", Mostrar(atacante));
                    Console.WriteLine("Defensor: {0}", Mostrar(defensor));
                    if (atacante[0] == defensor[0])
                    {
                        Console.WriteLine("Defornsor pierde 1;; {0} es mayor que {1}", atacante[1], defensor[1]);

                    }
                    else if (atacante[1] == defensor[1])
                    {
                        Console.WriteLine("Defensor pierde 1;; {0} es mayor que {1}", atacante[0], defensor[0]);
                        
                    }
                }
            }
            else
            {
                Console.WriteLine("Atacante: {0}", Mostrar(atacante));
                Console.WriteLine("Defensor: {0}", Mostrar(defensor));
                Console.WriteLine("Empate por regla gana el defensor");
            }


        }

        public string Mostrar(int[] pAtaDef)
        {
            string mostrar = "";
            mostrar += "[";
            for(int i = 0; i < pAtaDef.Length; i++)
            {
                if (i != pAtaDef.Length - 1)
                {
                    mostrar += string.Format("{0},", pAtaDef[i]);
                }
                else
                {
                    mostrar += pAtaDef[i].ToString();
                }
            }
            mostrar += "]";
            return mostrar;
        }

        public void BubbleSor(int[] numeros) {
            int aux=0;

            for(int i = 1; i < numeros.Length; i++)
            {
                for(int j = 0; j < numeros.Length-i ; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }

        }
        public void InsertionSort1(int[] numeros) {

            int posA;
            int dato=0;
            for(int i = 1; i < numeros.Length; i++)
            {
                posA = i;
                dato = numeros[i];

                while (posA > 0 && numeros[posA - 1] > dato)
                {
                    numeros[posA] = numeros[posA - 1];
                    posA--;
                }

                numeros[posA] = dato;
            }

        }
        public void InsertionSort2(int[] numeros) {
            int posA;
            int aux = 0;
            for (int i = 1; i < numeros.Length; i++)
            {
                posA = i;

                while (posA > 0 && numeros[posA - 1] > numeros[posA])
                {
                    aux = numeros[posA];
                    numeros[posA] = numeros[posA - 1];
                    numeros[posA - 1] = aux;
                    posA--;
                }

            }

        }
        public void SelectionSort(int[] numeros) {

            int imin;
            int aux;
            for(int i = 0; i < numeros.Length; i++)
            {
                imin = i;
                for(int j = i + 1;j< numeros.Length; j++)
                {
                    if (numeros[j] < numeros[imin]){
                        imin = j;
                    }
                }
                aux = numeros[i];
                numeros[i] = numeros[imin];
                numeros[imin] = aux;
            }
        }
    }
}
