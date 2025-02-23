using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Nome {  get; set; }
        public double SaldoConta { get; private set; }

        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double saldoConta) : this(numeroConta, nome) 
        {
            SaldoConta = saldoConta;
        }

        public void DepositoConta(double deposito)
        {
            SaldoConta += deposito;
        }

        public void SaqueConta(double saque)
        {
            SaldoConta -= saque + 5.0;
        }

        public override string ToString()
        {
            return "Numero da conta: " + NumeroConta + ", Nome: " + Nome + ", Saldo na conta: " + SaldoConta;
        }
    }
}
