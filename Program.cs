//Musica musica1 = new Musica();
//musica1.Nome = "Roxane";
//musica1.Artista = "The Police";
//musica1.Duracao = 273;
//musica1.Disponivel = true;

//Musica musica2 = new Musica();
//musica2.Nome = "Vertigo";
//musica2.Artista = "U2";
//musica2.Duracao = 367;
//musica2.Disponivel = false;

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();

Banda queen = new Banda("Queen");

Album albumDoQueem = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};

albumDoQueem.AdicionarMusica(musica1);
albumDoQueem.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueem);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueem.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(1, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Flavia");

Podcast podcast = new("Podcast especial", "Lucas");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();