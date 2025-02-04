namespace ScreenSound;

internal class Podcast
{
    private List<Episodio> episodios = new();
    public string Nome { get; }
    public string Dono { get; }
    public int numeroDeEps => episodios.Count;
    public int i { get; set; }
    public Podcast(string nome, string dono)
    {
        Nome = nome;
        Dono = dono;
    }
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void exbirEps()
    {
        i = 0;
        foreach (Episodio episode in episodios)
        {
            i++;
            Console.WriteLine($"\nnome do ep: {episode.NomedoEp}, duração do ep: {episode.Duração}min, host do ep: {episode.Host}");
            Console.WriteLine($"ordem do ep: {i}");
        }

    }
    public void exibirPodcast()
    {
        Console.WriteLine($"\nNome do podcast:{Nome} Dono dele:{Dono}");
    }
}