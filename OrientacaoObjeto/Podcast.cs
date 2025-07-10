using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();

    public string Host { get; set; }

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome { get; }
    
    public int TotalEpisodios => episodios.Count;
    
    

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    
    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} - Host: {Host} - quantia de episódios {TotalEpisodios}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Numero))
        {
            Console.WriteLine($"{episodio.Resumo}");
        }
        Console.WriteLine("\n");
    }

}