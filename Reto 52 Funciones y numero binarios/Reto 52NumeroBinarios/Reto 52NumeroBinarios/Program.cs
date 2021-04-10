using System;
using System.Text.Json;
using System.Text;
using System.IO;
namespace Reto_52NumeroBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Persona p1 = new Persona();
            p1.Edad = 21;
            p1.Nombre = "Marco";
            string sere=JsonSerializer.Serialize(p1);

            File.WriteAllText("texto.txt", sere);

            Persona p2 = JsonSerializer.Deserialize<Persona>(File.ReadAllText("texto.txt"));

        }
        
    }class Persona
    {
        private int edad;
        private string nombre;

        public int Edad { get { return edad; } set { edad = value; } }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
