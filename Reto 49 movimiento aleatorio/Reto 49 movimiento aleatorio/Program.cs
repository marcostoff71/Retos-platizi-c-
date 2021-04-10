using System;

namespace Reto_49_movimiento_aleatorio
{
    /*Tienes un robot que se mueve aleatoriamente en cuatro direcciones (arriba, abajo, izquierda y derecha) en un plano de 2 dimensiones (x, y) partiendo del origen (0, 0). Debes escribir un programa que indique cuantos pasos dará, registrar cuantos pasos dio en cada dirección y en que coordenada terminó su recorrido.*/
    struct Cordenada{
        public int x, y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int x, y;
            char[] direcciones = { 'w', 's', 'a', 'd' };
            Cordenada cordenada;
            cordenada.x = 0;
            cordenada.y = 0;
           

            Console.WriteLine("El robot comenzo en la cordenada 0");
            Console.Write("Cuantos pasos dara el robot: ");
            int pasos = int.Parse(Console.ReadLine());


            for (int i = 0; i < pasos; i++)
            {
                x = cordenada.x;
                y = cordenada.y;
                char d = direcciones[rd.Next(3)];
                switch (d)
                {
                    case 'w':
                        y--;
                        Console.WriteLine("Se movio para arriba");
                        break;
                    case 's':
                        y++;
                        Console.WriteLine("Se movio para abajo");
                        break;
                    case 'a':
                        x--;
                        Console.WriteLine("Se movio para la izquierda");
                        break;
                    case 'd':
                        x++;
                        Console.WriteLine("Se movio para la derecha");
                        break;
                }
                cordenada.x = x;
                cordenada.y = y;
            }
            Console.WriteLine("Las cordenadas finales fueron: x:{0} y:{1}", cordenada.x, cordenada.y);
        }
    }
}
