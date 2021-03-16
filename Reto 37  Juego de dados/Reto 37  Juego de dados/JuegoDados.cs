using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_37__Juego_de_dados
{
    class JuegoDados
    {
        int[] jugadores = new int[3];
        Random rdn = new Random();
        public void Inicar()
        {
            for(int i = 0; i < 3; i++)
            {
                for (int d = 0; d < 2; d++)
                {
                    int cara= rdn.Next(1, 6);
                    jugadores[i] += cara;
                    Console.WriteLine("Jugador {0} Tiro {1} Cara {2}", i + 1, d + 1, cara);
                }
            }
        }
        public void MostrarGanador()
        {
            if (jugadores[0] > jugadores[1] && jugadores[0] > jugadores[2])
            {
                Console.WriteLine("Gano el jugador 1");
            }else if(jugadores[1] > jugadores[0] && jugadores[1] > jugadores[2])
            {
                Console.WriteLine("Gano el jugador 2");
            }else if(jugadores[2] > jugadores[1] && jugadores[2] > jugadores[0])
            {
                Console.WriteLine("Gano el jugador 3");
            }
            else
            {
                Console.WriteLine("Es un empate");
            }
        }
    }
}
