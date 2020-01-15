using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio02
{
    class Carro:Veiculo
    {
        public string marca { get; set; }
        public int portas { get; set; }
        public int ano { get; set; }

        public Carro()
        {
        }

        public Carro(string marca, int portas, int ano, string modelo, int combustivel, int velocidade, int passageiros) : base(modelo,combustivel,velocidade,passageiros)
        {
            this.marca = marca;
            this.portas = portas;
            this.ano = ano;
        }

        public void mostrarDados()
        {
            base.mostrarDados();
            Console.WriteLine("Marca do carro  : " + this.marca);
            Console.WriteLine("Quantidade de Portas: " + this.portas);
            Console.WriteLine("Anodo carro : " + this.ano);




        }


    }




}
