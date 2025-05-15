//Banda baroes = new Banda("Barões da Pisadinha");

//Album album = new Album("O Maior Piseiro do Mundo");


//Musica musica1 = new Musica(baroes, "Volta Pra Mim")
//{
//    Duracao = 210,
//    Disponivel = true
//};

//Musica musica2 = new Musica(baroes, "Chamar Eu Bebê")
//{
//    Duracao = 310,
//    Disponivel = false
//};

//album.AdicionarMusica(musica1);
//album.AdicionarMusica(musica2);
//baroes.AdicionarAlbum(album);

//musica1.ExibirFichaTecnica();
//musica2.ExibirFichaTecnica();
//album.ExibirMusicasDoAlbum();
//baroes.ExibirDiscografia();

Episodio ep1 = new Episodio(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("José");

Episodio ep2 = new Episodio(2, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("fernando");
ep2.AdicionarConvidados("Ferndanda");
ep2.AdicionarConvidados("Ferndanda silva");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();