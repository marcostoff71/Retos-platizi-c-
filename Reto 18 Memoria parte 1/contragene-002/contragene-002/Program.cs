using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Constraseña_aleatorioa
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, longitud, indicestring;
            string alfabeto = "AaEeIiOoUuBbCcDdFfGgHhJjKkLlMmNnÑnPpQqRrSsTtVvWwXxYyZzChchLlllQuquGuguRrrr";
            string alfabetoConCaracteres = "0123456789@!&/()=[]*¨+´¿''¿AaBbCcDdEeFfGgHhIiJjKkLlMmNnÑñOoPpQqRrSsTtVvWxYyZz";
            Random aleatorio = new Random();
            string contraGene = "";

            do
            {
                Console.WriteLine("\t Generador de contraseñas ");
                Console.WriteLine("1. Crear contraseñas sin caracteres especiales");
                Console.WriteLine("2. Crear contraseñas con caracteres especiales");
                Console.WriteLine("3. Salir");
                //escogemos la opcion con el numero validado
                do
                {
                    opcion = ValidaNum("Escogue una opcion: ");

                } while (opcion < 1 || opcion > 3);
                if (opcion == 1)
                {
                    do
                    {
                        longitud = ValidaNum("Dame la longitud de la contraseña: ");
                    } while (longitud < 1);
                    for (int i = 0; i < longitud; i++)
                    {
                        indicestring = aleatorio.Next(0, alfabeto.Length);
                        contraGene+=(alfabeto[indicestring]);
                    }

                    Console.WriteLine("\tLa contraseña generada es: {0}", contraGene);
                    contraGene = "";
                    
                }
                else if (opcion == 2)
                {
                    do
                    {
                        longitud = ValidaNum("Dame la longitud de la contraseña: ");
                    } while (longitud < 1);
                    Console.WriteLine(longitud);
                    for (int i = 0; i < longitud; i++)
                    {
                        indicestring = aleatorio.Next(0, alfabetoConCaracteres.Length);
                        contraGene+=(alfabetoConCaracteres[indicestring]);
                    }

                    Console.WriteLine("\tLa contraseña generada es: {0}", contraGene);
                    
                }
                contraGene = "";
                Console.WriteLine();
            } while (opcion != 3);
            if (opcion == 3)
            {
                Console.Beep();
            }



        }
        static int ValidaNum(string mensaje)
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
    }
}