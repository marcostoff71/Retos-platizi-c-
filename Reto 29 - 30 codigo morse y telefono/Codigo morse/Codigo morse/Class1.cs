using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codigo_morse
{
    class CMorse
    {
        Dictionary<string, string> morse;
        string palabra="";
        string morseConvertido = "";
        public void Iniciar()
        {
            morse = new Dictionary<string, string> {
                

                            {"a", ".-"}, {"b", "-..."}, {"c", "-.-."}, {"d", "-.."},

                            {"e", "."}, {"f", "..-."}, {"g", "--."}, {"h", "...."},

                            {"i", ".."}, {"j", ".---"}, {"k", "-.-"}, {"l", ".-.."},

                            {"m", "--"}, {"n", "-."}, {"o", "---"}, {"p", ".--."},

                            {"q", "--.-"}, {"r", ".-."}, {"s", "..."}, {"t", "-"},

                            {"u", "..-"}, {"v", "...-"}, {"w", ".--"}, {"x", "-..- "},

                            {"y", "-.-- "}, {"z", "--.."}, {"0", "-----"}, {"1", ".----"},

                            {"2", "..---"}, {"3", "...--"}, {"4", "....-"}, {"5", "....."},

                            {"6", ".----"}, {"7", "..---"}, {"8", "...--"}, {"9", "....-"},

                            {" ", "//// "}, {".",".-.-.-"}, {",","--..--"}, {"?","..--.."},

                            {"!", "-.---"}

             };

                   
        
            

        }
        
        public void PedirPalabra()
        {
           
            do
            {
                Console.Write("Escribe lo que quieres traducir: ");
                palabra = Console.ReadLine().Trim();
                
                if (palabra.Length < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tError escribe algo");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } while (palabra.Length < 1);
            //convertimos la palabra en mayusculas
            palabra = palabra.ToLower();
        }
        public void traducir()
        {
            morseConvertido = "";
            foreach(char letra in palabra)
            {
                foreach(KeyValuePair<string,string> mor in morse)
                {
                    if (letra.ToString() == mor.Key)
                    {
                        morseConvertido += mor.Value;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\tTexto: {0} Morse: {1}",palabra,morseConvertido);
            Console.ResetColor();
        }
        public void traducirMorse()
        {

            foreach (char letra in palabra)
            {
                foreach (KeyValuePair<string, string> mor in morse)
                {
                    if (letra.ToString() == mor.Value)
                    {
                        morseConvertido += mor.Key;
                    }
                }
            }
            Console.WriteLine(morseConvertido);
        }
    }
}
