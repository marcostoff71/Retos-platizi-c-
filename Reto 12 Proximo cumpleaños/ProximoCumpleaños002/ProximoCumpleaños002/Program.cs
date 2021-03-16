using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProximoCumpleaños002
{
    class Program
    {
        private static int anioCumple, mesCumple, diaCumple, horaCumple,edad;
        static void Main(string[] args)
        {

            int opcion;
            string opcionHora;
            do
            {
                Console.WriteLine("\tDias para el proximo cumpleaños");
                Console.WriteLine("1 Proximo cumpleaños");
                Console.WriteLine("2 salir");
                do
                {
                    opcion = ValidaInt("Escogue una opcion: ");
                } while (opcion < 1 || opcion > 2);

                if (opcion == 1)
                {
                    Console.Write("Sabes la hora de nacimiento {SI/NO}: ");
                    opcionHora = Console.ReadLine().Trim().ToUpper();
                    if (opcionHora == "SI")
                    {
                        Console.WriteLine(CalculaCumpleHoras());
                    }
                    else
                    {
                        Console.WriteLine(CalculaCumple());
                    }
                }
                Console.WriteLine();

            } while (opcion != 2);
        }
        static int ValidaInt(string mensaje)
        {
            bool valor;
            int numfinal;
            do
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numfinal);
            } while (valor == false);
            return numfinal;
        }
        static string CalculaCumple()
        {
            diaCumple = ValidaInt("Dame el dia que naciste: ");
            mesCumple = ValidaInt("Dame el mes en el que naciste: ");
            anioCumple = ValidaInt("Dame el año en el que naciste: ");
            //creamos la fecha de nacimiento
            DateTime nacimiento = new DateTime(anioCumple, mesCumple, diaCumple);
            //calculamos la edad que se tiene
            edad = (DateTime.Now.Subtract(nacimiento).Days/365);
            //Despues calculamos el proximo cumpleaños

            DateTime proximoCumple;
            if (DateTime.Now >= nacimiento && DateTime.Now.Day >= diaCumple)
            {
                proximoCumple = new DateTime(DateTime.Now.AddYears(1).Year,mesCumple,diaCumple);
            }
            else
            {
                proximoCumple = new DateTime(DateTime.Now.Year, mesCumple, diaCumple);
            }
            StringBuilder sb = new StringBuilder();
            TimeSpan faltan = proximoCumple.Subtract(DateTime.Now);
            sb.AppendFormat("Tienes {0} años", edad);
            sb.AppendFormat("Para tu proximo cumpleaños faltan");
            sb.AppendFormat(" {0}:dias {1}:horas {2}:minutos", faltan.Days, faltan.Hours, faltan.Minutes);


            return (sb.ToString());



        }
        static string CalculaCumpleHoras()
        {
            diaCumple = ValidaInt("Dame el dia que naciste: ");
            horaCumple = ValidaInt("Dame la hora en que naciste {0/24}: ");
            mesCumple = ValidaInt("Dame el mes en el que naciste: ");
            anioCumple = ValidaInt("Dame el año en el que naciste: ");
            

            DateTime fechaNacimiento = new DateTime(anioCumple, mesCumple, diaCumple, horaCumple,0,0);

            //calculamos la edad;
            edad = (DateTime.Now.Subtract(fechaNacimiento).Days / 365);

            //cremaos el dato para el proximo cumple
            DateTime proximoCumple;
            //calculamos el proximo cumpleaños
            if (DateTime.Now >= fechaNacimiento && DateTime.Now.Day >= diaCumple)
            {
                proximoCumple = new DateTime(DateTime.Now.AddYears(1).Year, mesCumple, diaCumple, horaCumple, 0, 0);
            }
            else
            {
                proximoCumple = new DateTime(DateTime.Now.Year, mesCumple, diaCumple, horaCumple, 0, 0);
            }

            TimeSpan faltan = proximoCumple.Subtract(DateTime.Now);

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tienes {0} años", edad);
            sb.AppendFormat(" para tu proximo cumpleaños faltan ");
            sb.AppendFormat("{0}:dias {1}:horas {2}:minutos",faltan.Days,faltan.Hours,faltan.Minutes);


            return (sb.ToString());
            
        }
    }
}
