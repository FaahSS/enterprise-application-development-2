using Fiap.Banco.Model;
using System;

namespace _02_Fiap.Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar as contas
            ContaCorrente corrente = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 1,
                Saldo = 1000 ,
                Tipo = Model.TipoConta.Comum,
                DataAbertura = DateTime.Now
            };

            ContaPoupanca poupanca = new ContaPoupanca(100)
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 500,
                Taxa = 1,
                DataAbertura = new DateTime(2019, 1, 19)
            };

            corrente.Retirar(1500);
        }
    }
}
