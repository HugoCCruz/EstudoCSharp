using System.Net.Mime;
using System.Net.NetworkInformation;
using OrientacaoObjeto;

Banda queen = new Banda("Queen");   

Album albumldoQueen = new Album("A night ate the Opera");

Musica musica1 = new Musica(queen, "Love of my life") 
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumldoQueen.AdicionarMusica(musica1);
albumldoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumldoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
queen.ExibirDiscografia();


