using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.Classes
{
    public class Modelo
    {
        private string[] cargosMalhacao = { "Figurante", "Protagonista", "Vilão" };

        public Modelo(string nome, double altura, double peso, int idade)
        {
            Nome = nome;
            Altura = altura;
            Peso = peso;
            Idade = idade;
        }
        public Modelo() { }

        public string Nome { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }

        public virtual void MostrarDados()
        {
            Random cargoAleatorio = new Random();

            int cargo = cargoAleatorio.Next(cargosMalhacao.Length);

            Console.WriteLine($"Informações cadastradas:\n Nome: {Nome}\n Trabalho: {cargosMalhacao[cargo]} na Malhação!");
        }
    }
}
