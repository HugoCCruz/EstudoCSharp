namespace SpotiSound.Menus;
using SpotiSound.Modelos;

internal class Menu
{
    public virtual void Executar(Dictionary<string, Banda> dcBandas)
    {
        Console.Clear();
    }
    public void ConcatenarTitulo(string titulo)
    {
        int quantiaElementos = titulo.Length;
        String elementos = String.Empty.PadLeft(quantiaElementos, '-');
        Console.WriteLine(elementos);
        Console.WriteLine(titulo);
        Console.WriteLine(elementos + "\n");
    }

}
