using SpotiSound.Menus;
using SpotiSound.Modelos;

internal class MenuLista : Menu
{
    public override void Executar(Dictionary<string, Banda> dcBandas)
    {
        base.Executar(dcBandas);
        ConcatenarTitulo("Lista de bandas");
        if (dcBandas.Count == 0)
        {
            Console.WriteLine(" A lista está vazia no momento (T-T)");
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu");
            Console.ReadKey();
            Console.WriteLine("\nRetorando ao menu");
            Thread.Sleep(2000);
            Console.Clear();

        }
        else
        {

            foreach (string banda in dcBandas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
        }
        Console.WriteLine("Pressione qualquer tecla para retornar ao Menu");
        Console.ReadKey();
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(2000);
        Console.Clear();

    }
}


