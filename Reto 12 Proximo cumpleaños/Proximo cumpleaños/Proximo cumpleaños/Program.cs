
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proximo_cumpleaños
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaCumple, mesCumple, anioCumple;
            int edad;

            diaCumple = ValidaInt("Dame el dia de tu cumpleaños: ");
            mesCumple = ValidaInt("Dame el mes de tu cumpleaños: ");
            anioCumple = ValidaInt("Dame el año de tu cumpleaños: ");

            DateTime fechaNacimiento = new DateTime(anioCumple, mesCumple, diaCumple);
            //dia de nacimiento 
            //muestra la edad actual
            edad = DateTime.Now.Subtract(fechaNacimiento).Days;
            edad = edad / 365;
            //proximo cumpleaños 
            DateTime proximoCumple;
            //Define el proximo Cumple, En caso de que el mes sea menor al Mes Actual se busca el Próxima fecha que seria del año que viene
            //es por ello el AddYear(1)
            //En caso de ser mayor se toma el año actual
            if (DateTime.Now.Month>=fechaNacimiento.Month&&DateTime.Now.Day>=diaCumple)
            {
                Console.WriteLine(DateTime.Now.Day <= diaCumple);
                proximoCumple = new DateTime(DateTime.Now.AddYears(1).Year, mesCumple, diaCumple);
                Console.WriteLine("me estoy ejecutnado");
                Console.WriteLine(proximoCumple);
            }
            else 
            { 
                    proximoCumple = new DateTime(DateTime.Now.Year, mesCumple, diaCumple);
                Console.WriteLine("ME estoy ejecuentando else");
                Console.WriteLine(proximoCumple);
            }

            
            //Definiremos los dias faltantes para el proximo cumple
            TimeSpan faltan = proximoCumple.Subtract(DateTime.Now);
            
            Console.WriteLine("Para tu proximo cumpleaños faltan {0} dias {1} horas {2} minutos",faltan.Days,faltan.Hours,faltan.Minutes);


        }
        static int ValidaInt(string mensaje)
        {
            bool valor = false;
            int numFinal;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            } while (valor == false);
            return numFinal;
        }
        static string RetornarMensajeCumpleanio()
        {
            int diaCumple = 4;//Dia del Cumpleanios
            int mesCumple = 4;//Mes de Cumple 4=Abril
            int anioCumple = 1984; //Anio de Cumple
            DateTime fechaNacimiento = new DateTime(anioCumple, mesCumple, diaCumple);

            //Se calcula la Edad Actual A partir de la fecha actual Sustrayendo la fecha de nacimiento
            //esto devuelve un TimeSpan por tanto tomaremos los Dias y lo dividimos en 365 días
            int edad = (DateTime.Now.Subtract(fechaNacimiento).Days / 365);

            DateTime proximoCumple;
            //Define el proximo Cumple, En caso de que el mes sea menor al Mes Actual se busca el Próxima fecha que seria del año que viene
            //es por ello el AddYear(1)
            //En caso de ser mayor se toma el año actual
            if (DateTime.Now.Month <= mesCumple && DateTime.Now.Day <= diaCumple)
                proximoCumple = new DateTime(DateTime.Now.AddYears(1).Year, mesCumple, diaCumple);
            else
                proximoCumple = new DateTime(DateTime.Now.Year, mesCumple, diaCumple);


            //Definiremos los dias faltantes para el proximo cumple
            TimeSpan faltan = proximoCumple.Subtract(DateTime.Now);

            //Ahora Elaboramos el Mensaje
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Usted Tiene {0} Años ", edad);
            sb.AppendFormat("y tu Próximo Cumpleaños es: {0} Días", faltan.Days);
            sb.AppendFormat(", {0} Horas ", faltan.Hours);
            sb.AppendFormat("y {0} Minutos ", faltan.Minutes);

            return sb.ToString();
        }
    }
}
