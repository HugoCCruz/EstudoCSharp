using SpotiSound.Modelos;
namespace SpotiSound.Menus;

internal class MenuExibirDetalhes : Menu
{
  
    public override void Executar(Dictionary<string, Banda> dcBandas)
    {
        base.Executar(dcBandas);
        ConcatenarTitulo("Detalhes das bandas");
        Console.WriteLine("Qual banda deseja consultar?");
        string bandaEscolhida = Console.ReadLine()!;

        if (dcBandas.ContainsKey(bandaEscolhida))
        {
            Banda banda = dcBandas[bandaEscolhida];
            Console.WriteLine($"\nA média da banda {bandaEscolhida} é {banda.Media:F2}");
            Console.WriteLine($"Álbuns da banda:");
            if (banda.Albuns.Any())
            {
                foreach (var album in banda.Albuns)
                {
                    Console.WriteLine($"{album.Nome} | {album.Media:F2}");
                }
            }
            else
            {
                Console.WriteLine($"\nA banda {banda.Nome} não possui álbunsregistrados");
            }
                Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
            Console.ReadKey();
            Console.WriteLine("\nRetorando ao menu");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {bandaEscolhida} não foi encontrada");
        }
        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
        Console.ReadKey();
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(2000);
        Console.Clear();
        
    }

}
