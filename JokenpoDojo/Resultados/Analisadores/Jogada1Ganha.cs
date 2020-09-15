using System;
using JokenpoDojo.Jogadas;

namespace JokenpoDojo.Resultados
{
    public class Jogada1Ganha : AnalisadorDeJogada
    {
        protected override AnalisadorDeJogada ProximoAnalisador => new Jogada2Ganha();

        protected override string AnalisarJogada(Jogada jogada1, Jogada jogada2)
            => jogada1.GanhaDe(jogada2) ? "JOGADA 1" : default;
    }
}