// Carro.cs

using System;

public class Carro
{
    // Atributos da classe Carro
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    private bool Ligado { get; set; }

    // Construtor da classe Carro
    public Carro(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Ligado = false; // Por padrão, o carro está desligado ao ser criado
    }

    // Métodos da classe Carro
    public void Ligar()
    {
        Ligado = true;
        Console.WriteLine("O carro está ligado.");
    }

    public void Desligar()
    {
        Ligado = false;
        Console.WriteLine("O carro está desligado.");
    }
}
