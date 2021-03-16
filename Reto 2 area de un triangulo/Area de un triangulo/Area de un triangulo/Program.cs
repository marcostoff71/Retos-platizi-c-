using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_un_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Trinagulo trinagulo1 = new Trinagulo();
            Console.WriteLine(trinagulo1.ToString());
            trinagulo1.PedirInformacio();
            Console.WriteLine(trinagulo1.ToString());
        }
    }
    class Trinagulo
    {
        double base1, altura, area;

        //metodos
        public void PedirInformacio()
        {
            base1 = ValidaDouble("Dame la base del triangulo: ");
            altura = ValidaDouble("Dame la altura del triangulo: ");

            //operaciones 
            area = (base1 * altura) / 2;
        }
        
        public double ValidaDouble(string mensaje)
        {
            bool valor=false;
            double numFinal=0;

            while (valor == false)
            {
                Console.Write(mensaje);
                valor = double.TryParse(Console.ReadLine(), out numFinal);
            }
            return numFinal;
        }

        //mostramos la infromacion
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("El area del triangulo con base: {0}, altura: {1} es: {2}",base1,altura,area);
            
            return Convert.ToString(sb);
        }
    }
}
