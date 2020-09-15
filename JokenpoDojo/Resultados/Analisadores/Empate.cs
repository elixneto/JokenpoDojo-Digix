using JokenpoDojo.Jogadas;

namespace JokenpoDojo.Resultados
{
    public class Empate : AnalisadorDeJogada
    {
        protected override AnalisadorDeJogada ProximoAnalisador => new Jogada1Ganha();

        protected override string AnalisarJogada(Jogada jogada1, Jogada jogada2)
            => jogada1.GetType() == jogada2.GetType() ? "EMPATE" : default;
    }
}