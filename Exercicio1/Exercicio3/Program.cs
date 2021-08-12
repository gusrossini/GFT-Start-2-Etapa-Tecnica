using Exercicio3.Classes;
using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            var modelo1 = new Modelo("Gustavo", 1.70, 80.05, 25);

            modelo1.MostrarDados();

            var ator1 = new Ator("Estrela", "Gustavo", 1.70, 80.05, 25);

            ator1.MostrarDados();
        }
    }
}
