using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class MusicaDal
{
    private readonly ScreenSoundContext context;

    // Criando um construtor para o context
    public MusicaDal(ScreenSoundContext context)
    {
        this.context = context;
    }

    // Metodo listar musicas
    public IEnumerable<Musica> Listar()
    {
        return context.Musica.ToList();
    }

    // Metodo Adiconar Musica
    public void Adicionar(Musica musica)
    {
        context.Musica.Add(musica);
        context.SaveChanges();
    }

    //Metodo atualizar musicas
    public void AtualizarMusica(Musica musica)
    {
        context.Musica.Update(musica);
        context.SaveChanges();
    }

    // Metodo remover musica
    public void DeletarMusicas(Musica musica)
    {
        context.Musica.Remove(musica);
        context.Musica.Add(musica);
    }

    // Metodo Recuperar pelo nome
    public Musica? RecuperarPeloNome(string nome)
    {
        return context.Musica.FirstOrDefault(a => a.Nome.Equals(nome));
    }






}
