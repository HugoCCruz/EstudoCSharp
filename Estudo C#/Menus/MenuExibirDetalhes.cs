
using System;
using SpotiSound.Modelos;

namespace SpotiSound.Menus;

internal class MenuExibirDetalhes
{
    void ConcatenarTitulo(string titulo)
    {
        int quantiaElementos = titulo.Length;
        String elementos = String.Empty.PadLeft(quantiaElementos, '-');
        Console.WriteLine(elementos);
        Console.WriteLine(titulo);
        Console.WriteLine(elementos + "\n");
    }
    public void Executar(Dictionary<string, Banda> dcBandas)
    {
        Console.Clear();
        ConcatenarTitulo("Detalhes das bandas");
        Console.WriteLine("Qual banda deseja consultar?");
        string bandaEscolhida = Console.ReadLine()!;

        if (dcBandas.ContainsKey(bandaEscolhida))
        {
            Banda banda = dcBandas[bandaEscolhida];
            Console.WriteLine($"\nA média da banda {bandaEscolhida} é {banda.Media}");
            /*
            -
            */
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
