using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_teorema_de_pitagoras
{
    class Program
    {
        static void Main(string[] args)
        {
            CPitagoras p1 = new CPitagoras();
            p1.Inicar();
        }
    }
    class CPitagoras
    {
        private Punto A,B;
        public void Inicar()
        {
            pedirCordenadoas();
            Procedimineto();
        }
        public void pedirCordenadoas()
        {
            int x, y;
            x = ValidaInt("Dame la cordenadas de punto a x: ");
            y = ValidaInt("Dame la cordenadas de punto a y: ");
            A = new Punto(x, y);
            x = ValidaInt("Dame la cordenadas de punto b x: ");
            y = ValidaInt("Dame la cordenadas de punto b y: ");
            B = new Punto(x,y);




        }
        public int ValidaInt(string mensjae)
        {
            bool valor=false;
            int numFinal=0;
            while (valor == false)
            {
                Console.Write(mensjae);
                valor = int.TryParse(Console.ReadLine(), out numFinal);
            }
            return numFinal;
        }
        public void Procedimineto()
        {
            //formula:  d = √(xb - xa)2 + (yb - ya)2
            double distancia = 0;
            distancia = Math.Sqrt(Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2));

            Console.WriteLine("LA distancia que existe es : {0}", distancia);
        }
        
    }
    class Punto
    {
        private int _x;
        private int _y;
        public int x
        {
            get => _x;set => _x = value;
        }
        public int y { get => _y; set => _y = value; }
        public Punto(int px,int py)
        {
            _x = px;
            _y = py;
        }
    }
}
