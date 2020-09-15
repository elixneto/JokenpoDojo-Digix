namespace JokenpoDojo.Jogadas
{
    public class Tesoura : Jogada
    {
        public override string Nome => "Tesoura";

        public override bool GanhaDe(Jogada jogada)
            => jogada is Papel;
    }
}