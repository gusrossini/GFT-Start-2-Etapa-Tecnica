using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por gentileza, informe qual vacina foi aplicada:");
            Console.WriteLine("Digite 1 para  CoronaVac.");
            Console.WriteLine("Digite 2 para Janssen.");

            int vacina = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a data da primeira dose (DD MM AAAA): ");

            string[] data = Console.ReadLine().Split(' ');
            int dia = int.Parse(data[0]);
            int mes = int.Parse(data [1]);
            int ano = int.Parse(data [2]);

            var primeiraDose = new DateTime(ano, mes, dia);
            var segundaDose = primeiraDose.AddDays(14);
            
            if (vacina == 1)
            {
                Console.WriteLine("Coronavac: Intervalo de 14 dias.");
                Console.WriteLine($"Data da segunda dose: {segundaDose.ToString("dd/MM/yyyy")}");
            }
            else
            {
                Console.WriteLine("Janssen: Dose única.");
            }

            
            

            


        }
    }
}
