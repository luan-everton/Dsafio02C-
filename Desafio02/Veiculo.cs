using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02
{
    class Veiculo
    {
        public string Modelo { get; set; }
        public int Combustivel { get; set; }
        public int Velocidade { get; set; }
        public int Passageiros { get; set; }

        public Veiculo(string modelo, int combustivel, int velocidade, int passageiros)
        {
            Modelo = modelo;
            Combustivel = combustivel;
            Velocidade = velocidade;
            Passageiros = passageiros;
        }

        public Veiculo()
        {
        }

        public void mostrarDados()
        {
            Console.WriteLine("Modelo: " + this.Modelo);
            Console.WriteLine("Velocidade: " +this.Velocidade);
            Console.WriteLine("Limite de passageiros : " + this.Passageiros);
            Console.WriteLine("Limite de combustivel : "+ this.Combustivel);



        }


    }
}
