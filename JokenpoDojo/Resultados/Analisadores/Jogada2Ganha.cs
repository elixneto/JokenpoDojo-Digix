using JokenpoDojo.Jogadas;

namespace JokenpoDojo.Resultados
{
    public class Jogada2Ganha : AnalisadorDeJogada
    {
        protected override AnalisadorDeJogada ProximoAnalisador => null;

        protected override string AnalisarJogada(Jogada jogada1, Jogada jogada2)
            => jogada2.GanhaDe(jogada1) ? "JOGADA 2" : default;
    }
}