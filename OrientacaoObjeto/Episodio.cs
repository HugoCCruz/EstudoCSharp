using System.Threading.Channels;

class Episodio
{
    private List<string> convidados = new List<string>();
    public Episodio(int numero ,Podcast podcast, string titulo, int duracao)
    {
        Numero = numero;
       podcast = podcast;
        Titulo = titulo;
        Duracao = duracao;
    }
    
    public string Titulo { get; }
    public int Numero { get; }
    public int Duracao { get; }
    public string Resumo => $"{Numero} | {Titulo} - Convidados: {string.Join(", ", convidados)} | {Duracao}mim";



    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);  
    }
}
