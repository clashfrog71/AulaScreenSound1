using ScreenSound;
namespace ScreenSoundPrincipal;
class Aplicaçãoprincipal
{
    public static void Main()
    {
        int numerolimite = 2;
        Console.WriteLine("Aplicação para adicionar e excluir artistas e exibir podcasts, e adicionar tbm me esqueci de falar");
        Console.WriteLine($"esolha ai entre 1 e {numerolimite}");
        var resposta = Console.ReadLine();
        

        if (int.TryParse(resposta, out int respostaInt))
        {
            if (respostaInt > numerolimite)
            {
                Console.WriteLine("escolha inválida");
            }
            else
            {
                Console.WriteLine("escolheu " + respostaInt);
                switch (respostaInt)
                {
                    case 1:
                        Console.WriteLine("escolheu 1");
                        break;
                    case 2:
                        Console.WriteLine("escolheu 2");
                        break;
                }

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
        else
        {
            Console.WriteLine("escolha inválida");
        }
    }
}
