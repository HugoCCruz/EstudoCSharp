//SpotiSound
using SpotiSound.Menus;
using SpotiSound.Modelos;

string saudacao = "Olá, bem vindo ao SpotiSound!";

Banda bandaExemplo = new Banda("Banda exemplo");
bandaExemplo.AdicionarNota(new Avaliacao(10));
bandaExemplo.AdicionarNota(new Avaliacao(9));
bandaExemplo.AdicionarNota(new Avaliacao(6));


Dictionary<string, Banda> dcBandas = new Dictionary<string, Banda>(); 

dcBandas.Add(bandaExemplo.Nome, bandaExemplo);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuLista());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(0, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"
     ░██████╗██████╗░░█████╗░████████╗██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
     ██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
     ╚█████╗░██████╔╝██║░░██║░░░██║░░░██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
     ░╚═══██╗██╔═══╝░██║░░██║░░░██║░░░██║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
     ██████╔╝██║░░░░░╚█████╔╝░░░██║░░░██║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
     ╚═════╝░╚═╝░░░░░░╚════╝░░░░╚═╝░░░╚═╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine(saudacao);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("1 - Regitrar uma banda");
    Console.WriteLine("2 - Registrar Álbum");
    Console.WriteLine("3 - Lista de bandas");
    Console.WriteLine("4 - Avaliar uma banda");
    Console.WriteLine("5 - Mostrar detalhes");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("------------------------------------------------");

    Console.Write("\nSelecione a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int escolha = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(escolha))
    {
        Menu menu = opcoes[escolha];
        menu.Executar(dcBandas);
        if (escolha != 0) ExibirMenu();    
    }
    else
    {
        Console.WriteLine("Você selecionou uma opção inválida");
    }
}

ExibirMenu();