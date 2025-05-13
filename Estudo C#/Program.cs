//SpotiSound
using System.Diagnostics.Tracing;
using System.Runtime.Intrinsics.Arm;

string saudacao = "Olá, bem vindo ao SpotiSound!";
List<string> listaBandas = new List<string>();

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

void Menu()
{
    ExibirLogo();
    System.Console.WriteLine("------------------------------------------------");
    System.Console.WriteLine("1 - Regitrar uma banda");
    System.Console.WriteLine("2 - Lista de bandas");
    System.Console.WriteLine("3 - Avaliar uma banda");
    System.Console.WriteLine("3 - Média da banda");
    System.Console.WriteLine("0 - Sair");
    System.Console.WriteLine("------------------------------------------------");


    System.Console.Write("\nSelecione a opção desejada: ");
    string opcoes = System.Console.ReadLine()!;
    int escolha = int.Parse(opcoes);

    switch (escolha)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarLista();
            break;
        case 3:
            System.Console.WriteLine($"Você escolheu a opção {escolha}");
            break;
        case 0:
            System.Console.WriteLine($"Você Sair");
            break;
        default:
            System.Console.WriteLine("Você selecionou uma opção inválida");
            break;
    }
}


Menu();

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("------------------");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("------------------");
    Console.WriteLine("Digite o nome da banda que deseja registrar:");
    string nomebanda = Console.ReadLine()!;

    Console.WriteLine($"\n{nomebanda}\nO nome da banda está correto?");
    Console.WriteLine("1 - Sim\n2 - Não");
    string opcoes = System.Console.ReadLine()!;
    int escolha = int.Parse(opcoes);

    if (escolha == 1)
    {
        Console.WriteLine($"A banda {nomebanda} foi adicionada com sucesso!");
        listaBandas.Add(nomebanda);
    }
    else if (escolha == 2)
    {
        Console.WriteLine("digite o nome correto:");
        nomebanda = System.Console.ReadLine()!;
        Console.WriteLine($"A banda {nomebanda} foi adicionada com sucesso!");
        listaBandas.Add(nomebanda);
    }
    else
    {
        Console.WriteLine("Opção Incorreta");
    }
    Thread.Sleep(2000);
    Console.Clear();
    Menu();
}


void MostrarLista()
{
    Console.Clear();
    Console.WriteLine("------------------");
    Console.WriteLine("Lista de bandas");
    Console.WriteLine("------------------");
    for (int i = 0; i < listaBandas.Count; i++)
        Console.WriteLine($"{listaBandas[i]}");
    {

    }
}



