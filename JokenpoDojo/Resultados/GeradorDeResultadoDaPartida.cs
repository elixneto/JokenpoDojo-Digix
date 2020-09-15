using JokenpoDojo.Jogadas;

namespace JokenpoDojo.Resultados
{
    /* Início da CHAIN OF RESPONSABILITY */
    public class GeradorDeResultadoDaPartida
    {
        private readonly Jogada _jogada1;
        private readonly Jogada _jogada2;

        public GeradorDeResultadoDaPartida(Jogada jogada1, Jogada jogada2)
        {
            this._jogada1 = jogada1;
            this._jogada2 = jogada2;
        }

        public string ObterResultado() => new Empate().Analisar(_jogada1, _jogada2);
    }
}