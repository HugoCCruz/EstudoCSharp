using System.Net.Mime;
using System.Net.NetworkInformation;
using OrientacaoObjeto;

//Banda queen = new Banda("Queen");   

//Album albumldoQueen = new Album("A night ate the Opera");

//Musica musica1 = new Musica(queen, "Love of my life") 
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = false,
//};

//albumldoQueen.AdicionarMusica(musica1);
//albumldoQueen.AdicionarMusica(musica2);
//queen.AdicionarAlbum(albumldoQueen);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//queen.ExibirDiscografia();

Podcast flow = new Podcast("Flow Podcast", "Igor3k");

Episodio episodio1 = new Episodio(426, flow, "Jair Bolsonaro", 157);
episodio1.AdicionarConvidados("Jair Bolsonaro");

Episodio episodio2 = new Episodio(274, flow, "Danilo Gentili", 133);
episodio2.AdicionarConvidados("Danilo Gentili");

Episodio episodio3 = new Episodio(14, flow, "João Caetano", 64);
episodio3.AdicionarConvidados("João Caetano");


flow.AdicionarEpisodio(episodio1);
flow.AdicionarEpisodio(episodio2);
flow.AdicionarEpisodio(episodio3);
flow.ExibirDetalhes();

Podcast podpah = new Podcast("Podpah", "Igão e Mítico");

Episodio ep1 = new Episodio(1, podpah, "PODEROSÍSSIMO NINJA", 101);
ep1.AdicionarConvidados("ninja");

Episodio ep2 = new Episodio(931, podpah, "Cartolouco", 157);
ep2.AdicionarConvidados("Cartolouco");

podpah.AdicionarEpisodio(ep1);
podpah.AdicionarEpisodio(ep2);
podpah.ExibirDetalhes();


