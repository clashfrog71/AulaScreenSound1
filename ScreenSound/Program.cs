using ScreenSound;
namespace ScreenSoundPrincipal;
using ScreenSound.Seleção;
class Aplicaçãoprincipal
{
    public static void Main()
    {
        int numerolimite = 2;
        Console.WriteLine("Aplicação para adicionar e excluir artistas e exibir podcasts, e adicionar tbm me esqueci de falar");
        Console.WriteLine("escolha entre 1:(Artistas) e 2:(Podcast)");
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
                        SelecaoEpisodio.SelecaoEpisodiovoid();
                        break;
                }


            }
        }
        else
        {
            Console.WriteLine("escolha inválida");
        }
    }
}
