using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Analista
{
    class Carro : Veiculo
    {
        public Carro(double consumo)
        {
            combustivel = 0;
            this.consumo = consumo;
            velocidade = 50;
        }
  
       
    }
}
