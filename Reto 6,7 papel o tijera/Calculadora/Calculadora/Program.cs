using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2,resultado;
            string operador;

            num1 = ValidaNum("Dame el primer numero: ");
            Console.Write("Dame el operador: ");
            operador = Console.ReadLine();
            num2 = ValidaNum("Dame el segundo numeero: ");
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
                    break;
                case "-":
                    resultado = num1 - num2;
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, resultado);
                    break;
                case "*":
                    resultado = num1 * num2;
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, resultado);
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, resultado);
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    }
                    break;
                default:
                    Console.WriteLine("\toperador incorrecto");
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;


            }


        }
        static double ValidaNum(string mensaje)
        {
            bool valor = false;
            double Numfinal = 0;
            while(valor==false)
            {
                Console.Write(mensaje);
                valor = double.TryParse(Console.ReadLine(), out Numfinal);
            }
            return Numfinal;
        }
    }
}
