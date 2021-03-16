using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_38_Avanzando_nuestro_juego_de_datos
{
    class Program
    {
        /*
         #PlatziCodingChallenge Dia 39 - Avanzando nuestro juego de datos
        Crea una librería o biblioteca que contenga las funciones tirar dados, que reciba como parámetro cuántos dados van a ser tirados y que retorne los datos resultantes en forma de array. 💥*/
        static void Main(string[] args)
        {

            Dados d1 = new Dados();
            int[] a=d1.TiroDados(23);
            a.ToList().ForEach(i => Console.WriteLine(i));
        }
    }
}
