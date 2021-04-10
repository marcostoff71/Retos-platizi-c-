using System;

namespace Reto_50_validador_de_contraseñas
{
    /*
      En retos anteriores has creado un generador de contraseñas, ahora validarás su nivel de seguridad. Así que tu programa debe recibir un string con una contraseña considerando los siguientes parámetros:

        Incluir al menos una letra minúscula
        Incluir al menos una letra mayúscula
        Incluir al menos un número
        Incluir al menos un caracter especial
        Tener una longitud mínima de 8 caracteres
        Se evaluará la contraseña con las siguientes características:
        Insegura: cumple con solo 2 o menos parámetros
        Medianamente segura: cumple de 3 o 4 parámetros
        Segura: cumple con todos los parámetros
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa la contraseña: ");
            string contra = Console.ReadLine();
            FuezaBrutaContra(contra);



        }
        static char RegresarLetra(char op)
        {
            Random rdn = new Random();
            string letras = "abcdefghijklmnñopqrstuvwxyz";
            string letrasMa = letras.ToUpper();
            string numeros = "1234567890";
            string simbolos = "@$%&/()=?¡*¨{}-.,{}|°|¬";
            char re=' ';
            switch (op)
            {
                case 'M':
                    re = letrasMa[rdn.Next(letrasMa.Length - 1)];
                    break;
                case 'm':
                    re = letras[rdn.Next(letras.Length - 1)];
                    break;
                case 'N':
                    re = numeros[rdn.Next(numeros.Length - 1)];
                    break;
                case 'S':
                    re = simbolos[rdn.Next(simbolos.Length - 1)];
                    break;
            }
            

            return re;
        }
        static void FuezaBrutaContra(string contra)
        {
            char[] gene = new char[contra.Length];
            char[] adiv = contra.ToCharArray();
            
            
            long intentos = 0;
            
            do
            {
                Console.WriteLine("La longitud es de: {0}", adiv.Length);
                for (int i = 0; i < adiv.Length; i++)
                {
                    while (adiv[i] != gene[i])
                    {
                        if (char.IsWhiteSpace(adiv[i]))
                        {
                            
                            gene[i] = ' ';
                        }else 
                        if (char.IsDigit(adiv[i]))
                        {
                            gene[i] = RegresarLetra('N');
                            //Console.WriteLine("num");
                            
                        }
                        else if (char.IsUpper(adiv[i]))
                        {
                            gene[i] = RegresarLetra('M');
                            //Console.WriteLine("upper");
                            
                        }
                        else if (char.IsLower(adiv[i]))
                        {
                            gene[i] = RegresarLetra('m');
                            //Console.WriteLine("lowe");
                           
                        }
                        else
                        {
                            gene[i] = RegresarLetra('S');
                            //Console.WriteLine("simbo");
                            
                        }
                        intentos++;
                        Console.WriteLine("Intentos {0}", intentos);
                    }
                    Console.WriteLine("Generada la palabra: {0}", (i+1));
                }

                //intentos++;
                //Console.WriteLine("Intentos {0}", intentos);
                
            } while (new string(gene)!=new string(adiv));

            Console.WriteLine("LA contraseña es: {0}",new string(gene));
        }
        static string GeneradorContra(int mayus=0,int minu=0,int num=0,int sim=0)
        {
            Random rdn = new Random();

            string letras = "abcdefghijklnñopqrstvwxyz";
            string letrasMa = letras.ToUpper();
            string numeros = "1234567890";
            string simbolos = "@$%&/()=?¡*¨{}-.,{}|°|¬";


            string contra = "";

            for (int i = 0; i < mayus; i++) 
                contra += letrasMa[rdn.Next(letrasMa.Length - 1)];

            for (int i = 0; i < minu; i++) 
                contra += letras[rdn.Next(letras.Length - 1)];

            for (int i = 0; i < num; i++)
                contra += numeros[rdn.Next(numeros.Length - 1)];

            for (int i = 0; i < sim; i++)
                contra += simbolos[rdn.Next(simbolos.Length - 1)];

            
            return contra;
        }
        static void VerficarContra(string contra)
        {
            int mi=0, mayus=0, num=0, espe = 0;
            int requi = 0;
            if (contra.Length >= 8) requi++;
            for (int i = 0; i < contra.Length; i++)
            {
                if (char.IsUpper(contra[i]))
                {
                    mayus++;
                    if (mayus==1) requi++;
                }else if (char.IsLower(contra[i]))
                {
                    mi++;
                    if(mi==1)requi++;

                }else if (char.IsDigit(contra[i]))
                {
                    num++;
                    if(num==1)requi++;
                }else //if (char.IsSymbol(contra[i]))
                {
                    espe++;
                    if (espe == 1) requi++;
                }
            }
            Console.WriteLine("Ti contraseña cumple con {0} requisitos", requi);
            if (requi>=5)
            {
                Console.WriteLine("Contraseña muy segura");
            }else if (requi == 3 || requi == 4)
            {
                Console.WriteLine("Medianamente segura");
            }else if (requi <= 2)
            {
                Console.WriteLine("Contraseña insegura");
            }
        }
    }
}
