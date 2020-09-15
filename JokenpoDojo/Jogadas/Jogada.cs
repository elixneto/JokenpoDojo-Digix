namespace JokenpoDojo.Jogadas
{
    public abstract class Jogada
    {
        public abstract string Nome { get; }

        public abstract bool GanhaDe(Jogada jogada);
    }
}