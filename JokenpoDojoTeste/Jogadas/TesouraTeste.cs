using JokenpoDojo.Jogadas;
using Xunit;

namespace JokenpoDojoTeste.Jogadas
{
    public class TesouraTeste
    {
        private readonly Tesoura _tesoura = new Tesoura();

        [Fact]
        public void Deve_ganhar_de_Papel()
        {
            var papel = new Papel();

            Assert.True(_tesoura.GanhaDe(papel));
        }

        [Theory]
        [InlineData("Tesoura")]
        [InlineData("Pedra")]
        public void Nao_deve_ganhar_de(string nomeDaJogada)
        {
            var jogada = TodasAsJogadas.ObterPor(nomeDaJogada);

            Assert.False(_tesoura.GanhaDe(jogada));
        }
    }
}