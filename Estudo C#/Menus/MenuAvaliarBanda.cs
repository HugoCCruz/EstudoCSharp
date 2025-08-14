namespace SpotiSound.Menus;
using SpotiSound.Modelos;


internal class MenuAvaliarBanda : Menu
{

    public override void Executar(Dictionary<string, Banda> dcBandas) 
    {
        base.Executar(dcBandas);
        ConcatenarTitulo("Avaliar banda");
        Console.WriteLine("Qual banda deseja avaliar?");
        string bandaEscolhida = Console.ReadLine()!;

        if (dcBandas.ContainsKey(bandaEscolhida))
        {
            Banda banda = dcBandas[bandaEscolhida];
            Console.WriteLine("Qual nota você deseja dar para a banda?");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"\nA nota foi adiconada com sucesso!");
            Console.WriteLine("\nRetorando ao menu");
            Thread.Sleep(2000);
            Console.Clear();
            
        }
        else
        {
            Console.WriteLine($"\nA banda {bandaEscolhida} não foi encontrada! ");
            Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
            Console.ReadKey();
            Console.WriteLine("\nRetorando ao menu");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
