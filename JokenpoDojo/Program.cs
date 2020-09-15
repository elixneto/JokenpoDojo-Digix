using System;
using JokenpoDojo.Jogadas;
using JokenpoDojo.Resultados;

namespace JokenpoDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = new GeradorDeResultadoDaPartida(new Pedra(), new Papel());

            Console.WriteLine(resultado.ObterResultado());
        }
    }
}
