using Exercicio2.Classes;
using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario primeiroFuncionario = new Funcionario("Gustavo", "estagiario GFT", 800.00);

            primeiroFuncionario.GetDadosFuncionario();
            primeiroFuncionario.GetFormaDeTrabalho();
        }
    }
}
