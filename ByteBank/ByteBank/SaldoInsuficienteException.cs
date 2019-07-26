using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this("Tentativa de saque de " + valorSaque + " com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {
        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {
        }
    }
}
