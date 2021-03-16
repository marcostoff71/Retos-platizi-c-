using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_propina
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPlatos,propina;
            double precioTotal=0,precioFinal,precioPropina;
            do
            {
                numPlatos = ValidaInt("Dame el numero de platos: ");
            } while (numPlatos < 0);
            double[] precioPlatillos = new double[numPlatos];

            for(int i = 0; i < precioPlatillos.Length; i++)
            {
                do
                {
                    precioPlatillos[i] = ValidaDouble($"Dame el precio del platillo: {i + 1}: ");
                } while (precioPlatillos[i] <= 0);
                precioTotal += precioPlatillos[i];
            }
            //pedimos la propina
            do
            {
                propina = ValidaInt("Dame el porcentaje de propina: ");
            } while (propina < 0 || propina >= 100);
            //calculamos el precio final
            precioPropina = (precioTotal*propina)/100;
            precioFinal = precioTotal + precioPropina;
            Console.WriteLine("El total a pagar es de {0}",precioFinal);
        }
        static int ValidaInt(string menaje)
        {
            bool valor;
            int numFinal;
            do
            {
                Console.Write(menaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (valor == false);
            return numFinal;
        }
        static double ValidaDouble(string menaje)
        {
            bool valora;
            double numFinala;
            do
            {
                Console.Write(menaje);
                valora = double.TryParse(Console.ReadLine(), out numFinala);

            } while (valora == false);

            return numFinala;
        }


    }
}
