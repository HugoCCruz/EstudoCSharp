using SpotiSound.Menus;
using SpotiSound.Modelos;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> dcBandas)
    {
        Console.WriteLine($"Você escolheu sair");
    }
}
