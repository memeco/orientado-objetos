using System;

namespace ExemploCarro
{
    class Program
    {

        static void Main(string[] args)
        {
            // Criando um objeto Carro
            Carro meuCarro = new Carro("Toyota", "Corola", 2022);

            // Acessando e alterando atributos do carro
            Console.WriteLine($"Meu carro é um {meuCarro.Marca}");
            Console.WriteLine($"O modelo é: {meuCarro.Modelo}");
            Console.WriteLine($"e ano é {meuCarro.Ano}");

            meuCarro.Ligar();
            meuCarro.Desligar();
        }    

    }
}