using _02_Fiap.Exercicio01.Model;
using Fiap.Exercicio01.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{
    sealed class ContaCorrente : Conta
    {
        public TipoConta Tipo { get; set; }
        public override decimal Depositar(decimal valor)
        {
            Saldo+=valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Tipo == TipoConta.Comum && Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo-=valor;
            return Saldo;
        }
    }
}
