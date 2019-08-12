using _02_Fiap.Exercicio01.Model;
using Fiap.Exercicio01.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Banco.Model
{

    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Atributos
        private readonly decimal _rendimento;

        //Propriedades
        public decimal Taxa { get; set; }

        public decimal Rendimento
        {
            get { return _rendimento; }
        }

        //Construtor
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        //Métodos

        public override decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public override decimal Retirar(decimal valor)
        {
            if (Saldo < valor)
            {
                throw new SaldoInsuficienteException();
            }
            Saldo -= valor + Taxa;
            return Saldo;
        }
    }
}
