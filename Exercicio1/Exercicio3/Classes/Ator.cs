using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3.Classes
{
    public class Ator : Modelo
    {
        private string[] cargosNovela = { "Figurante", "Protagonista", "Vilão", "Coadjuvante", "Comediante" };

        public Ator(string nivelAtor, string nome, double altura, double peso, int idade)
        {
            NivelAtor = nivelAtor;
            Nome = nome;
            Altura = altura;
            Peso = peso;
            Idade = idade;
        }

        public string NivelAtor { get; set; }

        public override void MostrarDados()
        {
            Random cargoAleatorio = new Random();

            int cargo = cargoAleatorio.Next(cargosNovela.Length);

            Console.WriteLine($"Informações cadastradas:\n Nome: {Nome}\n Trabalho: {cargosNovela[cargo]} na Novela das 20h!");
        }
    }
}
