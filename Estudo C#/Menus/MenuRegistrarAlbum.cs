using SpotiSound.Menus;
using SpotiSound.Modelos;
internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> dcBandas)
    {
        base.Executar(dcBandas);
        ConcatenarTitulo("Registro de Álbum");
        Console.WriteLine("Digite a banda cujo álbum deseja registrar");
        string nomebanda = Console.ReadLine()!;
        if (dcBandas.ContainsKey(nomebanda))
        {
            Banda banda = dcBandas[nomebanda];
            Console.WriteLine("Digite o nome do Álbum: ");
            string nomealbum = Console.ReadLine()!;
            banda.AdicionarAlbum(new Album(nomealbum));
            Console.WriteLine($"O Álbum {nomealbum} de {nomebanda} foi registrado com sucesso");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {nomebanda} não foi encontrada.");
            Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
            Console.ReadKey();
            Console.WriteLine("\nRetorando ao menu");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}

