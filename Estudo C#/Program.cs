//SpotiSound
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

string saudacao = "Olá, bem vindo ao SpotiSound!";
//List<string> listaBandas = new List<string>();
Dictionary<string, List<int>>  dcBandas = new Dictionary<string, List<int>>(); 

dcBandas.Add("Banda Exemplo", new List<int> { 10, 5, 7});

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
    System.Console.WriteLine("4 - Média da banda");
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
            AvaliarBanda();
            break;
         case 4:
            Media();
            break;
        case 0:
            System.Console.WriteLine($"Você escolheu sair");
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
        //listaBandas.Add(nomebanda); Para adicionar uma banda à lista
        dcBandas.Add(nomebanda, new List<int>());//Para adicionar uma banda ao dicionário
    }
    else if (escolha == 2)
    {
        Console.WriteLine("digite o nome correto:");
        nomebanda = System.Console.ReadLine()!;
        Console.WriteLine($"A banda {nomebanda} foi adicionada com sucesso!");
        //listaBandas.Add(nomebanda);
        dcBandas.Add(nomebanda, new List<int>());
    }
    else
    {
        Console.WriteLine("Opção Incorreta");
    }

    Console.WriteLine("\nRetorando ao menu");
    Thread.Sleep(2000);
    Console.Clear();
    Menu();
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
        Menu();
    }
    else {
        //for (int i = 0; i < listaBandas.Count; i++) //    Para listar utiliando o for padrão
        //{
        //    listaBandas.Sort();//                          Deixa a lista em ordem alfabética
        //    Console.WriteLine($"Banda: {listaBandas[banda]}");
        //}
        foreach (string banda in dcBandas.Keys)
        {
           
            //listaBandas.Sort();// Deixa a lista em ordem alfabética mas deu erro
            Console.WriteLine($"Banda: {banda}");
            
            }

        }
        Console.WriteLine("Pressione qualquer tecla para retornar ao Menu");
        Console.ReadKey();
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(3000);
        Console.Clear();
        Menu();
    }


void AvaliarBanda()
{
    ConcatenarTitulo("Avaliar banda");
    Console.WriteLine("QUal banda deseja avaliar?");
    string bandaEscolhida = Console.ReadLine()!;

    if (dcBandas.ContainsKey(bandaEscolhida)) {
        Console.WriteLine("Qual nota você deseja dar para a banda?");
        int nota = int.Parse(Console.ReadLine()!);
        dcBandas[bandaEscolhida].Add(nota);
        Console.WriteLine($"\nA nota foi adiconada com sucesso!");
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(3000);
        Console.Clear();
        Menu();
    }
    else
    {
        Console.WriteLine($"\nA banda {bandaEscolhida} não foi encontrada! ");
        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
        Console.ReadKey();
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(3000);
        Console.Clear();
        Menu();
    }
    


}
void Media()
{
    ConcatenarTitulo("Média das bandas");
    Console.WriteLine("Qual banda deseja consultar?");
    string bandaEscolhida = Console.ReadLine()!;

    if (dcBandas.ContainsKey(bandaEscolhida))
    {
            List<int> notasBanda = dcBandas[bandaEscolhida];        
            Console.WriteLine($"A média da banda {bandaEscolhida} é {notasBanda.Average():F2}");
        
        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(3000);
        Console.Clear();
        Menu();
    }
    else
    {
        Console.WriteLine($"A banda {bandaEscolhida} não foi encontrada");
        Console.WriteLine("\nPressione qualquer tecla para retornar ao Menu");
        Console.ReadKey();
        Console.WriteLine("\nRetorando ao menu");
        Thread.Sleep(3000);
        Console.Clear();
        Menu();
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



