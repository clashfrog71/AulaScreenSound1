namespace ScreenSound.Seleção.Adicionar;

internal class AdicionarPodcast
{
    internal static void AdicionarPodcastvoid()
    {
        var asdasd = new Episodio("flow", "ep do davijones", 12);
        asdasd.adicionarConvidado("davijones");
        var asdasd22 = new Episodio("flow", "ep do davijones", 12);
        asdasd22.adicionarConvidado("davijones");

        var sdfghjklç = new Podcast("podcast super legal asdfghjklç", "mago davijones");
        sdfghjklç.AdicionarEpisodio(asdasd);
        sdfghjklç.AdicionarEpisodio(asdasd22);
        sdfghjklç.exbirEps();
        sdfghjklç.exibirPodcast();
    }
}
