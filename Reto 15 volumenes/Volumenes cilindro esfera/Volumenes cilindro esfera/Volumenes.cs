using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volumenes_cilindro_esfera
{
    
    class Volumenes
    {

        public double altura, radio,resultado;
        
        public void VolumenCilindro()
        {
            altura = ValiDouble("Dame un la altura del cilindro: ");
            radio = ValiDouble("Dame el radio del cilindro: ");
            resultado = Math.PI * (Math.Pow(radio, 2) * altura);
            Console.WriteLine("El volumen de cilindro es: {0}", resultado);
        }
        public void VolumenCubo()
        {
            altura = ValiDouble("Dame un lado del cubo: ");
            resultado = Math.Pow(altura,3);
            Console.WriteLine("El volumen del cubo es {0}", resultado);
        }
        public void VolumenEsfera()
        {
            radio = ValiDouble("Dame el radio de la esfera: ");
            resultado = (4 * (Math.PI * Math.Pow(radio, 3))) / 3;
            Console.WriteLine("El volumen de la esfera es {0}", resultado);
        }
        private double ValiDouble(string mensaje)
        {
            double numFinal;
            bool valor;
            do
            {
                Console.Write(mensaje);
                valor = double.TryParse(Console.ReadLine(), out numFinal);
            } while (valor == false);
            return numFinal;
        }
    }
}
