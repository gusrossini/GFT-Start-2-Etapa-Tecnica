using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Classes
{
    public class Funcionario
    {
        public Funcionario(string nome, string cargo, double salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        

        public void GetDadosFuncionario()
        {
            var mensagem = $"Informações dos funcionarios cadastrados:\n Nome: {Nome}\n Cargo: {Cargo}\n Salario: {Salario}";

            Console.WriteLine(mensagem);
        }


        public void GetFormaDeTrabalho()
        {
            if (Cargo.ToLower().Trim().Equals("estagiario") ||
                Cargo.ToLower().Trim().Equals("estagiário") ||
                Salario == 800)
            {
                Console.WriteLine($"O regime de trabalho do funcionário {Nome} é 100% home office.");
            }
            else if (Cargo.ToLower().Trim().Equals("junior") ||
                     Cargo.ToLower().Trim().Equals("júnior") ||
                     Salario == 1200)
            {
                Console.WriteLine($"O regime de trabalho do funcionário {Nome} é presencial.");
            }
            else if (Cargo.ToLower().Trim().Equals("senior") ||
                     Cargo.ToLower().Trim().Equals("sênior") ||
                     Salario == 2500)
            {
                Console.WriteLine($"O regime de trabalho do funcionário {Nome} é híbrido.");
            }
            else
            {
                Console.WriteLine($"O cargo e/ou salário do funcionário {Nome} não se aplicam para esse método.");
            }
        }
    }
}
