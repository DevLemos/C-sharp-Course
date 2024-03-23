using System;
using System.Globalization;

namespace ProjetoContaBancaria.Entities
{
    public class ContaBancaria
    {
         public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public ContaBancaria(int conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double saldo) :this( conta, titular)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}