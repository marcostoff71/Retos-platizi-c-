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
            //stin banco nuevo
            string bancoNuevo;
            CalculaAhorro();
            do
            {
                Console.Write("Nuevo mensaje de otro banco te ofrece 3% de iba mensual con un plus de 7% por año lo quieres aceptar (SI/NO): ");
                bancoNuevo = Console.ReadLine().Trim().ToUpper();
            } while (bancoNuevo != "SI" && bancoNuevo != "NO");
            if (bancoNuevo == "SI")
            {
                BancoNuevo();
            }

           

        }
        static void CalculaAhorro()
        {

            double dinero = 0, ahorroFinal = 0;
            int meses = 0, interes = 0;
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
                intereses += ((dinero * interes) / 100);
                ahorroFinal += intereses + dinero;
                if (mes == meses)
                {
                    Console.WriteLine("En {0} meses ahorraras: {1} con un interes de {2}% a tu favor", mes, ahorroFinal, intereses);
                }
            }
        }
        static void BancoNuevo()
        {
            double ahorro,dineroFinalA=0,dineroFinalB=0;
            double interesA=0, interesB=0;
            int meses;
            meses = 36;

            ahorro = ValidaDouble("Dame tus ahorro: ");

            for(int i = 1; i <= meses; i++)
            {
                interesA += ((ahorro * 4) / 100);
                interesB += ((ahorro * 3) / 100);
                
                if (i == 12)
                {
                    interesB += ((ahorro*7) /100);
                }
                else if(i==24){
                    interesB += ((ahorro * 7) / 100);
                }
                else if (i == 36)
                {
                    interesB += ((ahorro * 7) / 100);
                }

                dineroFinalA += ahorro + interesA;
                dineroFinalB += ahorro + interesB;

                if (i == 12)
                {
                    Console.WriteLine("En el banco A en un año tendras un ahorro de : {0} con un interes de {1}% mensual",dineroFinalA,4);
                    Console.WriteLine("En el banco B en un año tendras un ahorro de : {0} con un interes de {1}% mensual mas un interes plus anual de {2}",dineroFinalB,3,7);
                }
                else if (i == 24)
                {
                    Console.WriteLine("En el banco A en dos años tendras un ahorro de : {0} con un interes de {1}% mensual", dineroFinalA, 4);
                    Console.WriteLine("En el banco B en dos años tendras un ahorro de : {0} con un interes de {1}% mensual mas un interes plus anual de {2}", dineroFinalB, 3, 7);
                }
                else if (i == 36)
                {
                    Console.WriteLine("En el banco A en tres años tendras un ahorro de : {0} con un interes de {1}% mensual", dineroFinalA, 4);
                    Console.WriteLine("En el banco B en tres años tendras un ahorro de : {0} con un interes de {1}% mensual mas un interes plus anual de {2}", dineroFinalB, 3, 7);
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
