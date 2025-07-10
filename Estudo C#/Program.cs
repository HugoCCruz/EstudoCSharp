//SpotiSound
using SpotiSound.Modelos;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

string saudacao = "Olá, bem vindo ao SpotiSound!";


Banda bandaExemplo = new Banda("Banda exemplo");
bandaExemplo.AdicionarNota(10);
bandaExemplo.AdicionarNota(9);
bandaExemplo.AdicionarNota(6);


Dictionary<string, Banda>  dcBandas = new Dictionary<string, Banda>(); 

dcBandas.Add(bandaExemplo.Nome, bandaExemplo);

void ExibirLogo()
{
    System.Console.WriteLine(@"
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


    System.Console.Write("\nSelecione a opção desejada: ");
    string opcoes = System.Console.ReadLine()!;
    int escolha = int.Parse(opcoes);

    switch (escolha)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            RegistrarAlbum();
            break;
        case 3:
            MostrarLista();
            break;
        case 4:
            AvaliarBanda();
            break;
        case 5:
            ExibirDetalhes();
            break;
        case 0:
            System.Console.WriteLine($"Você escolheu sair");
            break;
        default:
            System.Console.WriteLine("Você selecionou uma opção inválida");
            break;
    }
}


ExibirMenu();

void RegistrarBanda()
{
    Console.Clear();
    ConcatenarTitulo("Regitro de Bandas");
    Console.WriteLine("Digite o nome da banda que deseja registrar:");
    string nomebanda = Console.ReadLine()!;

    Console.WriteLine($"\n{nomebanda}\nO nome da banda está correto?");
    Console.WriteLine("1 - Sim\n2 - Não");
    string opcoes = System.Console.ReadLine()!;
    int escolha = int.Parse(opcoes);

    if (escolha == 1)
    {
        Console.WriteLine($"A banda {nomebanda} foi adicionada com sucesso!");
        dcBandas.Add(nomebanda, new Banda(nomebanda));//Para adicionar uma banda ao dicionário
    }
    else if (escolha == 2)
    {
        Console.WriteLine("digite o nome correto:");
        nomebanda = System.Console.ReadLine()!;
        Console.WriteLine($"A banda {nomebanda} foi adicionada com sucesso!");
        dcBandas.Add(nomebanda, new Banda(nomebanda));
    }
    else
    {
        Console.WriteLine("Opção Incorreta");
    }

    Console.WriteLine("\nRetorando ao menu");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void RegistrarAlbum()
{
    Console.Clear();
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
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomebanda} não foi encontrada.");
        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
        Console.ReadKey();
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    
    
}

void MostrarLista()
{
    Console.Clear();
    ConcatenarTitulo("Lista de bandas");
    if (dcBandas.Count == 0)
    {
        Console.WriteLine(" A lista está vazia no momento (T-T)");
        Console.WriteLine("Pressione qualquer tecla para retornar ao Menu");
        Console.ReadKey();
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else {
        
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
        ExibirMenu();
    }


void AvaliarBanda()
{
    ConcatenarTitulo("Avaliar banda");
    Console.WriteLine("QUal banda deseja avaliar?");
    string bandaEscolhida = Console.ReadLine()!;

    if (dcBandas.ContainsKey(bandaEscolhida)) {
        Banda banda = dcBandas[bandaEscolhida];
        Console.WriteLine("Qual nota você deseja dar para a banda?");
        int nota = int.Parse(Console.ReadLine()!);
        banda.AdicionarNota(nota);
        Console.WriteLine($"\nA nota foi adiconada com sucesso!");
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {bandaEscolhida} não foi encontrada! ");
        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
        Console.ReadKey();
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    


}
void ExibirDetalhes()
{
    ConcatenarTitulo("Detalhes das bandas");
    Console.WriteLine("Qual banda deseja consultar?");
    string bandaEscolhida = Console.ReadLine()!;

    if (dcBandas.ContainsKey(bandaEscolhida))
    {
        Banda banda = dcBandas[bandaEscolhida];
        Console.WriteLine($"{banda.ExibirDiscografia}");
        
        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        Console.WriteLine($"A banda {bandaEscolhida} não foi encontrada");
        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
        Console.ReadKey();
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
}

void ConcatenarTitulo(string titulo)
{
    int quantiaElementos = titulo.Length;
    String elementos = String.Empty.PadLeft(quantiaElementos, '-');
    Console.WriteLine(elementos);
    Console.WriteLine(titulo);
    Console.WriteLine(elementos + "\n");
}



