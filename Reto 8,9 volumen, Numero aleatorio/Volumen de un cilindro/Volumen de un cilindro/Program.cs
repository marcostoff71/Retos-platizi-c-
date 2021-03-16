using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volumen_de_un_cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro1 = new Cilindro();
            cilindro1.PedirInformacion();
        }
        
    }
    class Cilindro
    {
        private double radio, altura, volumen;
        public double ValidaNum(string mensaje)
        {
            bool valor = false;
            double numFinal=0;
            while (!valor)
            {
                Console.Write(mensaje);
                valor = double.TryParse(Console.ReadLine(), out numFinal);
            }
            return numFinal;
        }
        public void PedirInformacion()
        {
            radio = ValidaNum("Dame el radio de la base del cilindro: ");
            altura = ValidaNum("Dame la altura del cilindro: ");

            //hacemos la operacion de calcular el volumen
            
            radio = Math.PI * Math.Pow(radio, 2);
            volumen = radio * altura;
            Console.WriteLine("El volumen es {0}", volumen);
        }
    }
}
