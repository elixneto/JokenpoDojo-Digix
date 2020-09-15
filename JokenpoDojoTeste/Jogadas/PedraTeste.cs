using JokenpoDojo.Jogadas;
using Xunit;

namespace JokenpoDojoTeste.Jogadas
{
    public class PedraTeste
    {
        private readonly Pedra _pedra = new Pedra();

        [Fact]
        public void Deve_ganhar_de_Tesoura()
        {
            var tesoura = new Tesoura();

            Assert.True(_pedra.GanhaDe(tesoura));
        }

        [Theory]
        [InlineData("Pedra")]
        [InlineData("Papel")]
        public void Nao_deve_ganhar_de(string nomeDaJogada)
        {
            var jogada = TodasAsJogadas.ObterPor(nomeDaJogada);

            Assert.False(_pedra.GanhaDe(jogada));
        }
    }
}