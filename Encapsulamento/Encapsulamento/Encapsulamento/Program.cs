using Encapsulamento;
using System;

class Program {
    static void Main(string[] args)
    {
        ContaBancaria conta;

        Console.Write("Digite o número da conta: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do titular da conta: ");
        string nome = Console.ReadLine();

        Console.Write("Haverá deposito inicial? (S/N): ");
        char resposta = char.Parse(Console.ReadLine());

        if (resposta == 'S' || resposta == 's')
        {
            Console.Write("Digite o valor do deposito inicial: ");
            double saldo = double.Parse(Console.ReadLine());
            conta = new ContaBancaria(numero, nome, saldo);
        }
        else
        {
            conta = new ContaBancaria(numero, nome);
        }

        Console.WriteLine("Dados da conta: " + conta.ToString());

        Console.Write("Digite um valor para deposito: ");
        double deposito = double.Parse(Console.ReadLine());
        conta.DepositoConta(deposito);

        Console.WriteLine("Dados atualizados: " + conta.ToString());

        Console.Write("Digite um valor para saque: ");
        double saque = double.Parse(Console.ReadLine());
        conta.SaqueConta(saque);

        Console.WriteLine("Dados atualizados: " + conta.ToString());
    }
}