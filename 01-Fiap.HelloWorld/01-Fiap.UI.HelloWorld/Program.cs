using _01_Fiap.UI.HelloWorld.Model;
using System;

namespace Fiap.UI.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro
            Carro carro = new Carro();
            //Atribuir um código ao carro
            carro.Codigo = 1;
            carro.Tipo = TipoCarro.Hatch;

            //Exibir o código do carro
            Console.WriteLine(carro.Codigo);
            Console.WriteLine("Hello World!");

            //Instanciar um carro 2
            Carro carro2 = new Carro()
            {
                Portas = 4,
                Valor = 100000,
                Tipo = TipoCarro.Hatch
            };
        }
    }
}
