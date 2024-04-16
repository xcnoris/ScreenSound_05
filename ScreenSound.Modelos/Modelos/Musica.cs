using ScreenSound.Modelos.Modelos;

namespace ScreenSound.Modelos;

public class Musica
{
    public Musica(string nome, string anoLancamento)
    {
        Nome = nome;
        AnoLancamento = anoLancamento;
    }

    public string Nome { get; set; }
    public int Id { get; set; }
    public string? AnoLancamento { get; set; }
    public Artista? Artista { get; set; }

    // usamos o virtual para que o entity framework posso manipular nossa propriedade
    public virtual ICollection<Genero> Generos { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
      
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}
        Artista: {Artista.Nome}";
        
        
    }
}