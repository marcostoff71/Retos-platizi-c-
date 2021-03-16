using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piedra_papel_o_tijera
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            
            int turno = 1, opcion;
            bool ganador = false;
            int gandorInt;
            string jugador1="", jugador2;
            
            while (ganador == false)
            {
                //mostra menu 
                
                if (turno == 1)
                {
                    Console.WriteLine("\tJugador 1");
                    //pedir piedra papel o tijera al juagdor 1
                    MostrarMenu();
                    do
                    {
                        opcion = ValidaNum("Seleciona una opcion: ");

                    }while(opcion > 3 || opcion < 1);
                    jugador1 = opcionSelecionada(opcion);
                    
                        turno = 2;
                    
                }else if (turno == 2)
                {
                    Console.WriteLine("\tJugador 2");
                    MostrarMenu();
                    //opcion = ValidaNum("Selcciona una opcion: ");
                    opcion = aleatorio.Next(1, 3);
                    Console.WriteLine("\tEl jugador 2 selecciona la opcion {0}", opcion);
                    jugador2 = opcionSelecionada(opcion);
                    if (jugador2 != "opcion incorrecta")
                    {
                        gandorInt = ComprobarGanador(jugador1, jugador2);
                        if (gandorInt == 1)
                        {
                            Console.WriteLine("\tGano el jugador 1");
                            ganador = true;
                        }
                        else if (gandorInt == 2)
                        {
                            Console.WriteLine("\tGano el jugador 2");
                            ganador = true;
                        }
                        else
                        {
                            Console.WriteLine("\tEmpate");
                            Console.WriteLine("_______________________");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\topcion incorrecta");
                    }
                    turno = 1;
                }
            }
            Console.ReadKey();

        }
        static int ValidaNum(string mensaje)
        {
            int numFinal = 0;
            bool valor = false;
            while (valor == false)
            {
                Console.Write(mensaje);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            }
            return numFinal;
        }
        static void MostrarMenu()
        {
            Console.WriteLine("1. Piedra");
            Console.WriteLine("2. Papel");
            Console.WriteLine("3. Tijera");
        }
        static string opcionSelecionada(int opcion)
        {
            string piedraPapelTijera;
            if (opcion == 1)
            {
                piedraPapelTijera = "Piedra";
                return piedraPapelTijera;
            }else if (opcion == 2)
            {
                piedraPapelTijera = "Papel";
                return piedraPapelTijera;
            }else if (opcion == 3)
            {
                piedraPapelTijera = "Tijera";
                return piedraPapelTijera;
            }
            else
            {
                return "opcion incorrecta";
            }

        }
        static int ComprobarGanador(string jugador1,string jugador2)//1 ganador jugador1__2 ganadro jugador 2__3empate
        {
            if (jugador1 == jugador2)
            {
                return 3;
            }
            else if (jugador1 == "Tijera" && jugador2 == "Papel"|| jugador2 == "Tijera" && jugador1 == "Papel")
            {
                if (jugador1 == "Tijera")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if (jugador1 == "Piedra" && jugador2 == "Tijera"|| jugador2 == "Piedra" && jugador1 == "Tijera") 
            {
                if (jugador1 == "Piedra")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else if(jugador1=="Papel"&&jugador2=="Piedra"|| jugador2 == "Papel" && jugador1 == "Piedra")
            {
                if (jugador1 == "Papel")
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                return 3;//empate
            }
            
        } 
    }
}
