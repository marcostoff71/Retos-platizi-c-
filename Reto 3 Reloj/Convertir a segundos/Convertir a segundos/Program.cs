using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertir_a_segundos
{
    class Program
    {
        static void Main(string[] args)
        {
            //hora tiene 3600 segundos 
            //minuto tiene 60 segundos
            int minutos, horas;
            Console.WriteLine("\tConvertir a segundos ");
            horas = validaNum("Dame las horas: ");
            minutos = validaNum("Dame los minutos: ");

            CalculaSegundo(horas, minutos);
        }
        static int validaNum(string mensaje)
        {
            bool valor = false;
            int numVali=0;
            while (valor == false)
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numVali);
            }
            return numVali;
            
    
        }
        static void CalculaSegundo(int horas,int minutos) 
        {
            int segundosHoras, segundosMinutos, segundosTotales;
            segundosHoras = horas * 3600;
            segundosMinutos = minutos * 60;
            segundosTotales = segundosHoras + segundosMinutos;
            Console.WriteLine("{0} horas en segundos son: {1}",horas,segundosHoras);
            Console.WriteLine("{0} minutos en segundos son: {1}",minutos,segundosMinutos);

            Console.WriteLine("{0} hora con {1} minutos en segundos son: {2}", horas, minutos, segundosTotales);
        }
    }
}
