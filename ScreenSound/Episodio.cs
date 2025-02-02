namespace ScreenSound
{
    class Episodio
    {
        private List<string> convidados = new();
        public Episodio(string host, string nomedoep, int duracao)
        {
            Host = host;
            NomedoEp = nomedoep;
            Duração = duracao;
        }
        public string Host { get; }
        public string Convidados { get; }
        public string NomedoEp { get; }
        public int Duração { get; }

        public void adicionarConvidado(string convidado)
        {
            convidados.Add(convidado);
        }
        public void exibirTudo()
        {
            Console.WriteLine($"Episódio: {NomedoEp}");
            Console.WriteLine($"Host: {Host}");
            Console.WriteLine($"Duração: {Duração} minutos");
            Console.WriteLine("Convidados:");

            foreach (var convidados in convidados)
            {
                Console.WriteLine($"- {convidados}");
            }
        }
    }
}