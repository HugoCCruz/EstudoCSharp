namespace SpotiSound.Modelos;
using System.Runtime.CompilerServices;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }

    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
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
            
        }
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
    }
}