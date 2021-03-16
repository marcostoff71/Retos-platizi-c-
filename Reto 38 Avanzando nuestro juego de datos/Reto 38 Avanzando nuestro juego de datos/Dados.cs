using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_38_Avanzando_nuestro_juego_de_datos
{
    class Dados
    {

        public int[] TiroDados(int numDados)
        {
            Random rdn = new Random();
            int[] dados = new int[numDados];
            for (int i = 0; i < dados.Length; i++)
            {
                dados[i] = rdn.Next(1, 6);
            }
            return dados;
        }
    }
}
