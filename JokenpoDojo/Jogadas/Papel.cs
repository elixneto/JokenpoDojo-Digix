namespace JokenpoDojo.Jogadas
{
    public class Papel : Jogada
    {
        public override string Nome => "Papel";

        public override bool GanhaDe(Jogada jogada)
            => jogada is Pedra;
    }
}