using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace calculadora_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Numeros = new ArrayList();
            string masNumero;
            double num=0,resultado=0,resultadoMulti=1;
            bool repetir = false;
            do
            {
                //pedimos el numero y lo agregagamos al arraylist
                num = ValidaNum("Dame el numero: ");
                Numeros.Add(num);

                do
                {
                    Console.Write("Deseas agregar mas numero[SI/NO]: ");
                    masNumero = Console.ReadLine().ToUpper();
                    
                } while (masNumero != "SI" && masNumero != "NO");

                if (masNumero == "SI")
                {
                    repetir = true;
                }
                else
                {
                    repetir = false;
                }

            } while (repetir==true);

            int opcion=0;
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Multiplicacion");
            while (opcion < 1 || opcion > 2)
            {
                opcion = ValidaNumInt("Escoge una opcion: ");
            }
            if (opcion == 1)
            {
                foreach(double i in Numeros)
                {
                    resultado += i;
                }
                InformacionFinal(opcion, resultado);
            }
            else
            {
                foreach(double i in Numeros)
                {
                    resultadoMulti *= i;
                }
                InformacionFinal(opcion, resultadoMulti);
            }
            
            

        }
        static double ValidaNum(string mensaje)
        {
            bool valor = false;
            double numFinal = 0;
            while (!valor)
            {
                Console.Write(mensaje);
                valor = double.TryParse(Console.ReadLine(), out numFinal);
            }
            return numFinal;
        }static int ValidaNumInt(string mensaje)
        {
            bool valor = false;
            int numFinal = 0;
            while (!valor)
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            }
            return numFinal;
        }
        static void InformacionFinal(int opcion, double resultado)
        {
            if (opcion == 1)
            {
                Console.WriteLine("La suma de todos los numero es: {0}", resultado);
            }
            else
            {
                Console.WriteLine("La multiplicacion de todos los numeros es: {0}", resultado);
            }
        }
    }
}
