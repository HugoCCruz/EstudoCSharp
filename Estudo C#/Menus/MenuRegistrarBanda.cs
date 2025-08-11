using SpotiSound.Menus;
using SpotiSound.Modelos;
internal class MenuRegistrarBanda : Menu
{
    public override void Executar(Dictionary<string, Banda> dcBandas)
    {
        base.Executar(dcBandas);
        ConcatenarTitulo("Regitro de Bandas");
        Console.WriteLine("Digite o nome da banda que deseja registrar:");
        string nomebanda = Console.ReadLine()!;

        Console.WriteLine($"\n{nomebanda}\nO nome da banda está correto?");
        Console.WriteLine("1 - Sim\n2 - Não");
        string opcoes = Console.ReadLine()!;
        int escolha = int.Parse(opcoes);

        if (escolha == 1)
        {
            Console.WriteLine($"A banda {nomebanda} foi adicionada com sucesso!");
            dcBandas.Add(nomebanda, new Banda(nomebanda));//Para adicionar uma banda ao dicionário
        }
        else if (escolha == 2)
        {
            Console.WriteLine("digite o nome correto:");
            nomebanda = Console.ReadLine()!;
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
    }
}

