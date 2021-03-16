using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos la clase o creamos el objeto
            CHolaMundo holamundo1 = new CHolaMundo();

            //llamamos al metodo del objetpo
            holamundo1.HolaMundo();

            Console.ReadKey();
        }
    }
    class CHolaMundo
    {
        
        //metodo
        public void HolaMundo()
        {
            Console.WriteLine("Hola mundo");
        }
    }
}
