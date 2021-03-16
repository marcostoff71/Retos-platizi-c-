using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tradu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string texto, textoVocal;
            Console.Write("Inserta un texto: ");
            texto = Console.ReadLine();
            textoVocal = ComprobarVocales(texto);
            textoVocal = comprobarConsonantes(textoVocal);
            Console.WriteLine(textoVocal);


            
        }
        static string ComprobarVocales(string texto)
        {
            char[] vocales =  { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú' };
            string textoFinal="";

            foreach (char i in vocales)
            {
                if (texto[0] == i || texto[0] == char.ToUpper(i))
                {
                    textoFinal = texto + "way";
                    return textoFinal;
                }
            }
                return textoFinal = texto;
            

        }
        static string comprobarConsonantes(string texto)
        {
            string primertexto="", textofinal = "";
            foreach(char letras in texto)
            {
                Console.WriteLine(letras);
                if (letras != 'a' && letras != 'e' && letras != 'i' && letras != 'o' && letras != 'u' && letras != 'á' && letras != 'é' && letras != 'í' && letras != 'ó' && letras != 'ú')
                {
                    
                    
                    primertexto = texto.Remove(1);
                    texto = texto.Remove(0, 1);
                    textofinal = texto + primertexto + "ay";
                    return textofinal;

                }
                
            }
            
            if (texto.Length <= 1)
            {
                
                return textofinal;
            }
            
            else
            {
                return textofinal=texto;
            }
            
            
        }








    }
}
