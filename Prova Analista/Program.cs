using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Analista
{
    class Program
    {
        static void Main(string[] args)
        {
            PostoGasolina postoGasolina = new PostoGasolina();
            Carro carro = new Carro(10);

            postoGasolina.Abastecer(carro, 50);
            double distanciaPercorrida = carro.Movimentar(50);
            double combustivelGasto = carro.ObterConsumo();
            double combustivelRestante = carro.CombustivelNoTanque();
            double tempoGasto = carro.ObterTempoGasto();

            Console.WriteLine("Distância percorrida: " + distanciaPercorrida + " Km");
            Console.WriteLine("Combustivel consumido: " + combustivelGasto + " Litros");
            Console.WriteLine("Combustivel restante: " + combustivelRestante + " Litros");
            Console.WriteLine("Tempo Gasto: " + tempoGasto + " Minutos");
            Console.ReadLine();




        }
    }
}
