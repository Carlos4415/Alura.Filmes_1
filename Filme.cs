namespace Alura.Filmes_1
{
    class Filme
    {
        private List<string> Elenco { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }

        public Filme(string titulo, int duracao, List<string>? elenco)
        {
            if (elenco == null)
            {
                Elenco = new List<string>();
            }
            else
            {
                Elenco = elenco;
            }

            Titulo = titulo;
            Duracao = duracao;
        }

        public void ListarElenco()
        {
            if (Elenco.Count == 0)
            {
                Console.WriteLine("Elenco vazio 0000.");
            }
            else
            {
                Console.WriteLine("Elenco...");
                foreach (var ator in Elenco)
                {
                    Console.WriteLine(ator);
                }
            }
        }
    }
}
