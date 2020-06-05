using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
           [console: UltimaParcela] Receba o valor total a ser pago e a quantidade de parcelas mensais de um financiamento. Exiba a data e o valor da última parcela.
           Ex. (considerando a data atual como 13/05/2020):
           Valor total do financiamento................: 985,12
           Quantidade de parcelas mensais (sem juros)..: 8
           Sua última parcela será em 13/01/2021, no valor de R$123,14.
           */

            Console.WriteLine("Usuário, por favor digite a seguir o valor total a ser pago:");

            decimal ValorASerPago = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Quantidade de parcelas mensais (sem juros):");

            // Eu solicito o valor total a ser pago e a quantidade de parcelas para realizar a conta.

            int QuantidadeDeParcelas = Convert.ToInt32(Console.ReadLine());

            decimal ValorMensalDaParcela = ValorASerPago / QuantidadeDeParcelas;

            // Esta operação ultiliza o valor do usuário que foi pedido no início do programa e dividi pelo núro de parcelas também fornecido pelo usuário.

            DateTime Tempo = DateTime.Now;

            DateTime Ultimo = Tempo.AddMonths(QuantidadeDeParcelas);

            // O comando AddMonths irá controlar os meses da parcela.

            Console.WriteLine($"Sua última parcela deverá ser paga somente em {Ultimo.ToShortDateString()}, no valor total de R${ValorASerPago}.");

        }
    }
}
