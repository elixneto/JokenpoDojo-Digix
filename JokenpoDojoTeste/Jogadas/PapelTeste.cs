using JokenpoDojo.Jogadas;
using Xunit;

namespace JokenpoDojoTeste.Jogadas
{
    public class PapelTeste
    {
        private readonly Papel _papel = new Papel();

        [Fact]
        public void Deve_ganhar_de_Pedra()
        {
            var pedra = new Pedra();

            Assert.True(_papel.GanhaDe(pedra));
        }

        [Theory]
        [InlineData("Papel")]
        [InlineData("Tesoura")]
        public void Nao_deve_ganhar_de(string nomeDaJogada)
        {
            var jogada = TodasAsJogadas.ObterPor(nomeDaJogada);

            Assert.False(_papel.GanhaDe(jogada));
        }
    }
}