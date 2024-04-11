using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class ArtistaDal : DAL<Artista>
{
    private readonly ScreenSoundContext context;

    // Criando um construtor para o context
    public ArtistaDal(ScreenSoundContext context)
    {
        this.context = context;
    }

    // Lista todos os artistas
    public override IEnumerable<Artista> Listar()
    { 
        return context.Artistas.ToList();
    }

    // Adiciona novos artistas a tabela
    public override void Adicionar(Artista artista)
    { 
        context.Artistas.Add(artista);
        context.SaveChanges();
    }

    // Atualiza dados da tabela
    public override void Atualizar(Artista artista)
    {
        context.Artistas.Update(artista);
        context.SaveChanges();
    }

    // Deleta dados da tabela
    public override void Deletar(Artista artista)
    {
        context.Artistas.Remove(artista);
        context.SaveChanges();
    }

    public  Artista? RecuparPeloNome(string valorBusca)
    {

        return context.Artistas.FirstOrDefault(a => a.Nome.Equals(valorBusca));
    }
}
