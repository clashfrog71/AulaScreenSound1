using ScreenSound.Seleção.Adicionar;
namespace ScreenSound.Seleção;

internal class SelecaoPodcast
{
    internal static void SelecaoEpisodiovoid()
    {
        bool loop = true;
        while (loop)
        {
            Console.Clear();

            Console.WriteLine("escollhe ai 1(adiciona) e 2(amostra)");
            var resposta = Console.ReadLine();
            if (int.TryParse(resposta, out int repostaint))
            {
                switch (repostaint)
                {
                    case 1:
                        AdicionarPodcast.AdicionarPodcastvoid();
                        break;
                    case 2:
                        Console.WriteLine("escolheu 2");
                        break;
                }

                loop = false;
            }
            else
            {
                Console.WriteLine("escolha inválida");
            }

        }
    }
}

