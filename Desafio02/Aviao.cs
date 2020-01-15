using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02
{
    class Aviao:Veiculo
    {
        public string tipo { get; set; }
        public string Uso { get; set; }

        public Aviao(string tipo, string uso, string modelo, int combustivel, int velocidade, int passageiros) :base(modelo,combustivel,velocidade,passageiros)

        {
            this.tipo = tipo;
            this.Uso = uso;
        }

        public Aviao()
        {
        }

        public void mostrardados()
        {
            base.mostrarDados();

            Console.WriteLine("Qual o tipo " + this.tipo);

            Console.WriteLine("Pra que é usado : " + this.Uso);


        }


    }
}
