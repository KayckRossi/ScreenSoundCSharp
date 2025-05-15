Banda baroes = new Banda("Barões da Pisadinha");

Album album = new Album("O Maior Piseiro do Mundo");


Musica musica1 = new Musica(baroes, "Volta Pra Mim")
{
    Duracao = 210,
    Disponivel = true
};

Musica musica2 = new Musica(baroes, "Chamar Eu Bebê")
{
    Duracao = 310,
    Disponivel = false
};

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);
baroes.AdicionarAlbum(album);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
album.ExibirMusicasDoAlbum();
baroes.ExibirDiscografia();