using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Seleção
{
    internal class SelecaoEpisodio
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
                    var asdasd = new Episodio("flow", "ep do davijones", 12);
                    asdasd.adicionarConvidado("davijones");
                    var asdasd22 = new Episodio("flow", "ep do davijones", 12);
                    asdasd22.adicionarConvidado("davijones");

                    var sdfghjklç = new Podcast("podcast super legal asdfghjklç", "mago davijones");
                    sdfghjklç.AdicionarEpisodio(asdasd);
                    sdfghjklç.AdicionarEpisodio(asdasd22);
                    sdfghjklç.exbirEps();
                    sdfghjklç.exibirPodcast();
                    loop = false;
                }
                else
                {
                    Console.WriteLine("escolha inválida");
                }

            }
        }
    }
}
