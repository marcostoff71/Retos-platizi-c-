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
            CalculaAhorro();

        }
        static void CalculaAhorro()
        {
            
                double dinero=0, ahorroFinal = 0;
                int meses=0,interes=0;
                double intereses = 0;

           
                Console.WriteLine("\tCuanto vas a ahorrar");
                do
                {
                    dinero = ValidaDouble("Dame el ahorro: ");
                } while (dinero < 1);
                do
                {
                    interes = ValidaInt("Dame los interes a tu favor: ");
                } while (interes < 0);
                do
                {
                    meses = ValidaInt("Dame los meses que vas a ahorrar: ");
                } while (meses < 1);
                
                for (int mes = 1; mes <= meses; mes++)
                {

                    
                    
                    intereses +=((dinero * interes) / 100);
                    Console.WriteLine(intereses);
                    ahorroFinal += intereses + dinero;
                    Console.WriteLine(ahorroFinal);
                    

                    if (mes == meses)
                    {
                        Console.WriteLine("En {0} meses ahorraras: {1} con un interes de {2}% a tu favor",mes, ahorroFinal,intereses);
                    }
                    

                }
                
                
              
        }
        static int ValidaInt(string mensaje)
        {
            bool valor;
            int numFinal;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (valor != true);
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
