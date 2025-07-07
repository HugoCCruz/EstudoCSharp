using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
      class Musica
    {

        public Musica(Banda artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }

        public string Nome {get; set;}
        public Banda Artista { get;}   
        public int Duracao { get; set; }  
        public bool Disponivel { get; set; }
        public Genero Genero { get; set; }
        public string DescricaoResumida => $"A musica {Nome} pertence à banda {Artista}";


        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel)
            {
                Console.WriteLine("Disponível no plano.");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+");
            }
        }
    }

   
}

