using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class MusicaDal : DAL<Musica>
{
    // O costrutor receber o contexto da class DAL
    public MusicaDal(ScreenSoundContext context): base(context) { }


    // Metodo Recuperar pelo nome
    public Musica? RecuperarPeloNome(string nome)
    {
        return context.Musica.FirstOrDefault(a => a.Nome.Equals(nome));
    }
}
