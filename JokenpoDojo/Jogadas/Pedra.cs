namespace JokenpoDojo.Jogadas
{
    public class Pedra : Jogada
    {
        public override string Nome => "Pedra";

        public override bool GanhaDe(Jogada jogada)
            => jogada is Tesoura;
    }
}