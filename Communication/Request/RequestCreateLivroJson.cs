using LivrariaOnline.Entities;

namespace LivrariaOnline.Communication.Request;

public class RequestCreateLivroJson
{
    public int Id { get; set; } = 1;
    public string Nome { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public Genero Genero { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
}

