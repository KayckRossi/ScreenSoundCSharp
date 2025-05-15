class Musica
{
    public Musica(Banda artista) 
    {
        Artista = artista;
    }

    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }

    //uma propriedade, criada como lambda

    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";

   
    //criação do metodo/comportamentos da classe
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista:{Artista}");
        Console.WriteLine($"Duração:{Duracao}");

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