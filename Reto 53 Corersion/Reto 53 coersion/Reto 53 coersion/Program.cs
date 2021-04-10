using System;

namespace Reto_53_coersion
{
    /*
     Crea una función que reciba un número como un string y lo devuelva como un entero. ¿Qué pasa si el string no representa un número? ¿Puedes hacer que devuelva flotantes también? Por ejemplo:*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RegresarNum("32.3223"));

        }
        static float RegresarNum(string texto)
        {
            float num;
            try
            {
                num = float.Parse(texto);
            }
            catch (Exception)
            {

                return default(float);
            }
            return num;
        }
    }
}
