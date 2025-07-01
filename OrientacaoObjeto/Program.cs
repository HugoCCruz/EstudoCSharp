using System.Net.Mime;
using System.Net.NetworkInformation;
using OrientacaoObjeto;

Album albumldoQueen = new Album();
albumldoQueen.Nome = "A night ate the Opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumldoQueen.AdicionarMusica(musica1);
albumldoQueen.AdicionarMusica(musica2);

albumldoQueen.ExibirAlbum();


