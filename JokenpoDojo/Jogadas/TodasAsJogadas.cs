using System.Collections.Generic;
using System.Linq;

namespace JokenpoDojo.Jogadas
{
    public static class TodasAsJogadas
    {
        public static IReadOnlyCollection<Jogada> Obter() =>
            new List<Jogada>
                {
                    new Pedra(),
                    new Papel(),
                    new Tesoura()
                }
                .AsReadOnly();

        public static Jogada ObterPor(string nome) =>
            Obter().SingleOrDefault(partida => partida.Nome.Equals(nome));
    }
}