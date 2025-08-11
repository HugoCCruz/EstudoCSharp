namespace SpotiSound.Modelos;  

internal class Banda
{

    private List<Album> albums = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>(); 
    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
    public double Media
    {
        get
        {
            if (albums.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public List<Album> Albuns => albums;

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);

    }
    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda: {Nome}");
        Console.WriteLine($"Nota: {Media}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome} ({Math.Round(album.DuracaoTotal / 60.0, 2)} minutos)");
        }
    }
}
