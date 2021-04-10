using System;

namespace Reto_48
{
    class Program
    {
        /*Crea un programa al cual pueda recibir de entrada algún texto, de preferencia algo que tenga la extensión de uno o varios párrafos. Al mismo tiempo debe poder recibir otra palabra y contar la frecuencia de la misma en el primer texto. Tu programa debe ser capaz de reconocer mayúsuclas, minúsculas y caracteres especiales.*/
        static void Main(string[] args)
        {
            string texto = "",bus;
            int veces = 0;
            do
            {
                Console.WriteLine("Ingresa un texto: ");
                texto = Console.ReadLine().Trim();
            } while (texto.Length == 0);
            do
            {
                Console.WriteLine("Ingresa la palabra a buscar: ");
                bus = Console.ReadLine().Trim();
            } while (texto.Length==0);

            veces = FrecuenciaPabra(texto, bus);
            Console.WriteLine("Las veces que se repite la palabra: {0} son {1}", bus, veces);
        }
        static int FrecuenciaPabra(string texto,string palabraBus)
        {
            int con = 0;
            //splitameamos el texot en palabras y lo guardamoe en un arry de string y todo lo ponemos en mayusculas
            string[] palabras = texto.ToUpper().Split(' ', ',','.');

            //quitamos los espacion des arry para ayor facilidad
            for (int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = palabras[i].Trim();
            }

            //la palabras a buscar tambien la converimos a myusculas
            palabraBus = palabraBus.ToUpper();


            //recorresmo el array con un forech
            foreach (string pa in palabras)
            {
                //si la palabras a buscar es igual a la palabra que se esta recorriendo elevemos nuestro conteo 
                if (palabraBus == pa)
                {
                    con++;
                }
            }

            //retornamos el numero de veces que aparece la palabra a buscar en el texto
            return con;
        }
    }
}
