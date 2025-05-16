using System.Net.Http.Headers;
using System.Net.Mail;
using System.Runtime.InteropServices;

Dictionary<string, List<int>> Alunos = new Dictionary<string, List<int>>();
Alunos.Add("Maria", new List<int> { 10, 8, 9});
Alunos.Add("João", new List<int> { 3, 5, 8});
Alunos.Add("Hugo", new List<int> { 10, 10, 6 });

Dictionary<string, int> Estoque = new Dictionary<string, int>();
Estoque.Add("Leite", 10);
Estoque.Add("Açúcar", 5);
Estoque.Add("Café", 20);
Estoque.Add("Macarrão", 3);

Dictionary<string, int> Login = new Dictionary<string, int >();
Login.Add("adm", 1234);

void Menu()
{
    
    System.Console.WriteLine("------------------------------------------------");
    System.Console.WriteLine("1 - Dicionário de alunos");
    System.Console.WriteLine("2 - Estoque de loja");
    System.Console.WriteLine("3 - Sistema Login");
    System.Console.WriteLine("0 - Sair");
    System.Console.WriteLine("------------------------------------------------");


    System.Console.Write("\nSelecione a opção desejada: ");
    string opcoes = System.Console.ReadLine()!;
    int escolha = int.Parse(opcoes);

    switch (escolha)
    {
        case 1:
            CaseAlunos();
            break;
        case 2:
            EstoqueMercado();
            break;
        case 3:
            SistemaLogin();
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

void CaseAlunos()
{
    Console.WriteLine("média dos Alunos");

    foreach(var aluno in Alunos)
    {
        //Utilizando um sistema para calcular a média
        double soma = 0;
        for (int i = 0; i < aluno.Value.Count; i++)
        {
            soma += aluno.Value[i];
        }
        double media = soma / aluno.Value.Count;
        Console.WriteLine($"A média do aluno {aluno} é {media}");

        //Utilizando o Comando Average() que calcula automaticamente a média da lista de uma chave
        for (int i = 0; i < aluno.Value.Count; i++)
        {
            Console.WriteLine($"A média do aluno {aluno} é {aluno.Value.Average()}");

        }

    }

}

void EstoqueMercado()
{
    Console.WriteLine("Estoque de Mercado");

    Console.WriteLine("Digite o nome do produto que deseja consultar:");
    string produto = Console.ReadLine()!;

    if (Estoque.ContainsKey(produto))
    {
        Console.WriteLine($"Há {Estoque[produto]}unidades de {produto}");
    }
    else
    {
        Console.WriteLine("Não foi possível encontrar este produto");
    }
}

void SistemaLogin()
{
    Console.WriteLine("1 - Logar\n2 - Criar Conta");
    string escolha = Console.ReadLine()!;
    string user = "";
    int senha = 0;
    if (escolha == "1")
    {
        Console.WriteLine("Digite o nome de usuário");
        user = Console.ReadLine()!;
        if (Login.ContainsKey(user))
        {
            Console.WriteLine("Digite a senha");
            senha = int.Parse(Console.ReadLine()!);
            if (Login.ContainsValue(senha)) 
            {
                Console.WriteLine("Seja bem vindo!");
            }
        }
    }
    else if( escolha == "2")
    {
        Console.WriteLine("Digite o nome de usuário");
        user = Console.ReadLine()!;
        Console.WriteLine("Agora digite o pin");
        senha = int.Parse(Console.ReadLine()!);
        Login.Add(user, senha);
    }
    else
    {
        Console.WriteLine("Escolha uma opção válida");
    }

}