using System;
using System.Text;

namespace Reto_47_vacas_y_toros
{
    /*
     Crea un programa para jugar “Vacas y toros” con el jugador. El juego consiste en que se genera un número aleatorio de 4 dígitos (no visible) y el usuario debe ingresar un número igualmente de 4 dígitos. Por cada dígito acertado el jugador “obtiene” una vaca y si no acierta alguno “obtiene” un toro. Muestra en pantalla los resultados y termina el juego cuando el usuario tenga 10 vacas.
     */
    class Program
    {
        static void Main(string[] args)
        {

            VacasYToros v1 = new VacasYToros();
            v1.Jugar();
        }
    }
    class VacasYToros
    {
        public void Jugar()
        {
            string ingresado="";
            string adivinar = numAle().ToString();
            int vacas = 0, toros = 0;
            do
            {
                int con=0;
                do
                {
                    Console.Write("Ingresa un numero: ");
                    ingresado = Console.ReadLine();

                } while (!esNum(ingresado) || ingresado.Length != 4);

                for (int i = 0; i < adivinar.Length; i++)
                {
                    for (int j = 0; j < ingresado.Length; j++)
                    {
                        if (adivinar[i] == ingresado[j])
                        {
                            con++;
                        }
                    }
                }
                if (con > 0)
                {
                    vacas += con;
                    Console.WriteLine("Ganaste {0} vacas",con);
                }
                else
                {
                    Console.WriteLine("Ganaste un toro");
                    toros++;
                }
                if (vacas >= 10)
                {
                    Console.WriteLine("Felicidades ganaste");
                }
            } while (vacas < 10);
        }
        private bool esNum(string texto)
        {
            int num;
            bool valor = int.TryParse(texto, out num);
            return valor;
        }
        private int numAle()
        {
            Random rdn = new Random();
            return rdn.Next(1000,9999);
        }
    }
}
