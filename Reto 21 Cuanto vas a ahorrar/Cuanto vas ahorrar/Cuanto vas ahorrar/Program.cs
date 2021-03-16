using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuanto_vas_ahorrar
{
    class Program
    {
        static void Main(string[] args)
        {
            string salir = "";
            double dinero,ahorroFinal=0,interes=0;

            do
            {
                Console.WriteLine("\tCuanto vas a ahorrar tasa de interes 4%");
                dinero = ValidaDouble("Dame el ahorro: ");

                for(int mes=1;mes <= 24; mes++)
                {
                    interes += (dinero * 0.04);
                    ahorroFinal += interes+dinero;
                    if (mes == 6)
                    {
                        Console.WriteLine("En 6 meses ahorraras: {0} con una tasa de interes de {1}", ahorroFinal,interes);
                    }else if(mes == 12)
                    {
                        Console.WriteLine("En 1 año ahorraras: {0} con una tasa de interes de {1}", ahorroFinal,interes);
                    }else if(mes == 24)
                    {
                        Console.WriteLine("En 2 años ahorraras: {0} con una tasa de interes de {1}", ahorroFinal,interes);
                    }
                    
                }
                Console.WriteLine("Deseas salir (SI/NO)");
                salir = Console.ReadLine().Trim().ToUpper();


            } while (salir != "SI");

        }
        static int ValidaInt(string mensaje)
        {
            bool valor;
            int numFinal;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            }while(valor != true);
            return numFinal;
        }
        static double ValidaDouble(string mensaje)
        {
            bool valor;
            double numFinal;
            do
            {
                Console.Write(mensaje);
                valor = double.TryParse(Console.ReadLine(), out numFinal);
            } while (valor != true);
            return numFinal;
        }
    }
}
