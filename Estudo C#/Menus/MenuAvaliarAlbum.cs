using SpotiSound.Menus;
using SpotiSound.Modelos;
using System;

internal class MenuAvaliarAlbum : Menu
    {
    public override void Executar(Dictionary<string, Banda> dcBandas)
    {
        base.Executar(dcBandas);
        ConcatenarTitulo("Avaliar álbum");
        Console.WriteLine("De qual banda deseja avaliar o álbum?");
        string bandaEscolhida = Console.ReadLine()!;

        if (dcBandas.ContainsKey(bandaEscolhida))
        {
            Banda banda = dcBandas[bandaEscolhida];
            Console.WriteLine("Digite o nome do Álbum: ");
            string nomealbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(nomealbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(nomealbum));
                Console.WriteLine("Qual nota você deseja dar para o álbum?");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA nota foi adiconada com sucesso!");
                Console.WriteLine("\nRetorando ao menu");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"O álbum {nomealbum} não foi encontrado");
                Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
                Console.ReadKey();
                Console.WriteLine("\nRetorando ao menu");
                Thread.Sleep(2000);
                Console.Clear();
            }

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

