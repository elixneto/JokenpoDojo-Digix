using System;
using JokenpoDojo.Jogadas;

namespace JokenpoDojo.Resultados
{
    /* Nó da CHAIN OF RESPONSABILITY */
    public abstract class AnalisadorDeJogada
    {
        protected abstract AnalisadorDeJogada ProximoAnalisador { get; }
        protected abstract string AnalisarJogada(Jogada jogada1, Jogada jogada2);

        public string Analisar(Jogada jogada1, Jogada jogada2)
        {
            var resultadoDaJogada = AnalisarJogada(jogada1, jogada2);

            if (resultadoDaJogada == default)
                if (ProximoAnalisador != null)
                    return ProximoAnalisador.Analisar(jogada1, jogada2);
                else
                    return "!Jogada Inválida!";
            else
                return resultadoDaJogada;
        }
    }
}