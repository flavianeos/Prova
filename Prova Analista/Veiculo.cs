using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Analista
{
    abstract class  Veiculo

    {
       public double combustivel;
       public double consumo;
       public double velocidade;
       public double tempoGasto;

       public double Movimentar(double km)
        {
            consumo = (km / consumo);
            combustivel -= consumo;
            tempoGasto = (velocidade / km) * 60;
            return km;
        }
       public double CombustivelNoTanque()
        {
            return combustivel;
        }

        public double ObterConsumo()
        {
            return consumo;
        }
        public double ObterTempoGasto()
        {
            return tempoGasto;
        }


        

    }
}
