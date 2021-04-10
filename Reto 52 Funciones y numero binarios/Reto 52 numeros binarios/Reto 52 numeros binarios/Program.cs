using System;

namespace Reto_52_numeros_binarios
{
    /*
     La forma en la que funcionan las computadoras es con números binarios. ¿Puedes crear una función que reciba un número en base decimal y lo regrese en binario? Por ejemplo:
    14 -> 1110
    38 -> 100110
    127 -> 1111111
    Aquí está el twist: no puedes utilizar las librerías de los lenguajes como la función bin en Python.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DecimalABina(100));
        }
        static int DecimalABina(int num)
        {
            string bina = "";
            if (num == 0)
            {
                bina += 0.ToString();
            }
            while (num > 1)
            {
                int re=
                (num % 2);
                bina += re.ToString();
                num = (num)/ 2;
            }
            return int.Parse(bina);
        }
    }
}
