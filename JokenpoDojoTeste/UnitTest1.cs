using System;
using Xunit;
using JokenpoDojo;

namespace JokenpoDojoTeste
{
    public class UnitTest1
    {
        [Fact]
        public void Deve_empatar()
        {
            Itens primeiraEntrada = Itens.Papel, segundaEntrada = Itens.Papel;
            var mensagemDeRetorno = "Empate";

            var jokenpo = new Jokenpo();            

            Action.Equals(mensagemDeRetorno);
        }
    }
}
