Banda baroes = new Banda("Barões da Pisadinha");
baroes.Nome = "dda";

Album album = new Album();
album.Nome = "O Maior Piseiro do Mundo";

Musica musica1 = new Musica(baroes);
musica1.Nome = "Volta Pra Mim";
musica1.Duracao = 210;

Musica musica2 = new Musica(baroes);
musica2.Nome = "Chamar Eu Bebê";
musica2.Duracao = 310;

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);


baroes.AdicionarAlbum(album); 
baroes.ExibirDiscografia();