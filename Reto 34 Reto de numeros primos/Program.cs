using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_34_Reto_de_numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num;
            //Console.WriteLine("Cual sera el numero primo");
            //Console.Write("Dame el numero: ");
            //num = int.Parse(Console.ReadLine());
            //int re = CalcularPrimo2(num);
            //Console.WriteLine(re);
            List lista = new List();
            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);
            lista.Agregar(5);
            lista.Agregar(6);
            lista.Agregar(7);
            lista.Mostrar();
            Console.WriteLine();
            Console.WriteLine(lista[0]);
            lista[0] = 32;
            lista.Mostrar();
            Console.WriteLine(lista[22]);
            

        }
        static int CalcarPrimoN(int n)
        {
            int aux=0;
            int cont=0;
            do
            {
                aux++;
                if (esPrimo(aux))
                {
                    cont++;
                }
            } while (cont != n);
            return aux;
        }
        static bool esPrimo(int n)
        {
            int cont = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int CalcularPrimo2(int n)
        {
            int num=0, aux=0;
            do
            {
                num++;
                if (esPrimo(num))
                {
                    aux++;
                }
                
                
            } while (aux != n);

            return num;
        }
        
        
    }
    class Nodo
    {
        private int dato;
        private Nodo siguiente;
        public int Dato { get => dato; set => dato = value; }
        public Nodo Siguiente { get => siguiente; set => siguiente = value; }
    }
    class List 
    {
        private Nodo Lista;
        public List()
        {
            Lista = null;
        }
        public void Agregar(int num)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Dato = num;

            Nodo aux = null;
            if (Lista == null)
            {
                Lista = nuevoNodo;
                nuevoNodo.Siguiente = null;
            }
            else
            {
                aux = Lista;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }

                aux.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = null;
            }
        }
        public void Mostrar()
        {
            Nodo aux = Lista;
            while (aux != null)
            {
                Console.Write("{0} ,", aux.Dato);
                aux = aux.Siguiente;
            }
        }
        public void Eliminar(int num)
        {
            if (Lista == null)
            {

            }
            else
            {

                Nodo auxBorrar = Lista;
                Nodo anterior=null;
                while (auxBorrar != null && auxBorrar.Dato != num)
                {
                    anterior = auxBorrar;
                    auxBorrar = auxBorrar.Siguiente;
                }
                if (auxBorrar == null)
                {
                    object a = "No encontrado";
                    Console.WriteLine(a.ToString());
                }else
                if (anterior == null)
                {
                    Lista = Lista.Siguiente;
                }
                else
                {
                    anterior.Siguiente = auxBorrar.Siguiente;
                }
            }
        }
        public int Elementos()
        {
            int cont = 0;
            Nodo aux = Lista;

            while (aux != null)
            {
                cont++;
                aux = aux.Siguiente;
            }
            return cont;
        }
        public Nodo ObtenerPorIndice(int indice)
        {
            Nodo aux = null;
            if (indice < Elementos()&&indice>=0&&Lista!=null)
            {
                
                if (indice == 0)
                {
                    aux = Lista;
                }
                else
                {
                    aux = Lista;
                    int cont = 0;
                    while (aux.Siguiente != null && cont < indice)
                    {
                        cont++;
                        aux = aux.Siguiente;
                    }
                }
            }
            return aux;
        }
        public int this[int pindice]
        {
            get
            {
                if (pindice >= 0 && pindice < this.Elementos())
                {
                    return ObtenerPorIndice(pindice).Dato;
                }
                else
                {
                    throw new Exception("Fuera de los indices");
                }
                
            }
            set
            {
                if (pindice >= 0 && pindice < this.Elementos())
                {
                    Nodo aux1;
                    aux1 = ObtenerPorIndice(pindice);
                    aux1.Dato = value;
                }
                else
                {
                    throw new Exception("Fuera de los indices");
                }
                
            }
        }
    }
}
