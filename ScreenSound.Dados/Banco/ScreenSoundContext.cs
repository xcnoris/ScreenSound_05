using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using ScreenSound.Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

public class ScreenSoundContext : DbContext
{
    //Conexao com o banco de dados
    private string stringDeConexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

    // Metodo de conexao do Entity Framework com banco 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(stringDeConexao);
    }

    // Explicitando o relacionamento de musicas e generos para o entity framework
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Musica>()
            .HasMany(c => c.Generos)
            .WithMany(c => c.Musicas);
    }

    //Os objetos DbSet são usados para trabalhar com os conjuntos de entidades, nesse caso, entidades do tipo Receita.

    // Referenciando a class Artista
    public DbSet<Artista> Artistas { get; set; }

    // Referenciando a class Musica
    public DbSet<Musica> Musica { get; set; }
    public DbSet<Genero> Generos { get; set; }   


}
