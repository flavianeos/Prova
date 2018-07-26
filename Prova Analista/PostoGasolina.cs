using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Analista
{
    class PostoGasolina
    {
        public void Abastecer(Veiculo veiculo, double combustivel)
        {
            veiculo.combustivel += combustivel;
        }
    }
}
