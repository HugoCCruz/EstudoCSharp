using OrientacaoObjeto;
using System.Runtime.CompilerServices;

class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; 

    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }
    public void ExibirAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum: {Nome}");
        if (DuracaoTotal > 3600)
        {
            Console.WriteLine($"Duração total: {Math.Round((DuracaoTotal/60)/60.0,2)} horas");
        }
        else
        {
            Console.WriteLine($"Duração total: {Math.Round(DuracaoTotal / 60.0, 2)} minutos\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Musica: {musica.Nome}");
            }
        }
        
    }
}