using System;
using System.Collections.Generic;

namespace Reto_44_Generador_de_ips
{
    /*
     Una IP se compone de 4 números separados por un punto (.) y estos van del 0 al 255. Debes crear un programa que genere IPs de forma aleatoria con estas características (ejemplo: 1.127.0.231), puedes indicarle que genere 1000 distintas y depués validar si se repite alguna o listarlas en orden ascendiente.*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GeneradorDeIps gene = new GeneradorDeIps();
            

            gene.GenerarIPCanOrde(100).ForEach(i => Console.WriteLine(i));
        }
        
    }
    class GeneradorDeIps
    {
        public List<string> GenerarIPCanOrde(int cantidad)
        {
            int cont = 0;
            List<string> lstIps = GenerarIps(cantidad);
            foreach (string ip in lstIps)
            {
                cont += lstIps.FindAll(item => item == ip).Count-1;
            }
            Console.WriteLine("Se repita {0}", cont);
            lstIps.Sort();
            return lstIps;
        }
        public List<string> GenerarIps(int cantidad)
        {
            List<string> lstIp = new List<string>();

            for (int i = 0; i < cantidad; i++)
            {

                string gene;
                //do
                //{
                    gene = GeneIps();
                //} while (lstIp.Contains(gene) == true);
                lstIp.Add(gene);
            }
            return lstIp;
        }
        public string GeneIps()
        {
            string ip = "";
            for (int i = 0; i < 4; i++)
            {
                if (i != 3)
                {
                    ip += Generador().ToString()+".";

                }
                else
                {
                    ip += Generador().ToString();
                }

            }
            return ip;
        }
        public int Generador()
        {
            Random rdn = new Random();
            int numGene = rdn.Next(0, 255);
            return numGene;
        }
    }
}
