using System.ComponentModel.DataAnnotations;

namespace LivrariaOnline.Entities;

public class Livro
{
    public int Id { get; set; }
    [Required]
    public string Nome { get; set; } = string.Empty;
    [Required]
    public string Autor { get; set; } = string.Empty;
    public Genero Genero { get; set; }
    [Required]
    public double Preco { get; set; }
    [Required]
    public int Estoque { get; set; }

}

