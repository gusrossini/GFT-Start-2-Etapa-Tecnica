using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da moto?");
            Console.Write("R$:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o numero correspondente à forma de pagamento desejada:");
            Console.WriteLine("1 - A vista - 30% de desconto!!");
            Console.WriteLine("2 - A prazo");
            int pagamento = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorAVista, juros, valorParcelas;

            if (pagamento == 1)
            {
                valorAVista = valor - (valor * 0.3);
                Console.WriteLine($"Valor final da moto: R${valorAVista.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Informe o numero de parcelas (5, 11, 17, 23, ou 29):");
                double parcelas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double valorAPrazo;
                if (parcelas == 5)
                {
                    juros = 0.04;
                    valorAPrazo = valor + (valor * (juros + (juros * parcelas)));
                    valorParcelas = valorAPrazo / parcelas;
                    Console.WriteLine($"Preço final: R${valorAPrazo.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Quantidade de parcelas: R${parcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Valor das parcelas: R${valorParcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else if (parcelas == 11)
                {
                    juros = 0.07;
                    valorAPrazo = valor + (valor * (juros + (juros * parcelas)));
                    valorParcelas = valorAPrazo / parcelas;
                    Console.WriteLine($"Preço final: R${valorAPrazo.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Quantidade de parcelas: R${parcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Valor das parcelas: R${valorParcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else if (parcelas == 17)
                {
                    juros = 0.1;
                    valorAPrazo = valor + (valor * (juros + (juros * parcelas)));
                    valorParcelas = valorAPrazo / parcelas;
                    Console.WriteLine($"Preço final: R${valorAPrazo.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Quantidade de parcelas: R${parcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Valor das parcelas: R${valorParcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else if (parcelas == 23)
                {
                    juros = 0.13;
                    valorAPrazo = valor + (valor * (juros + (juros * parcelas)));
                    valorParcelas = valorAPrazo / parcelas;
                    Console.WriteLine($"Preço final: R${valorAPrazo.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Quantidade de parcelas: R${parcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Valor das parcelas: R${valorParcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else if (parcelas == 29)
                {
                    juros = 0.16;
                    valorAPrazo = valor + (valor * (juros + (juros * parcelas)));
                    valorParcelas = valorAPrazo / parcelas;
                    Console.WriteLine($"Preço final: R${valorAPrazo.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Quantidade de parcelas: R${parcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"Valor das parcelas: R${valorParcelas.ToString("F2", CultureInfo.InvariantCulture)}");
                }
                else
                {
                    Console.WriteLine("Numero de parcelas nao condiz com as possibilidades.");                 
                }
                

            }
        }
    }
}
