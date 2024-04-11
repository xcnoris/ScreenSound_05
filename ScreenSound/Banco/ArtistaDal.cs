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
    // O costrutor receber o contexto da class DAL
    public ArtistaDal(ScreenSoundContext context): base(context) { }


    // Metodo Recuperar pelo nome
    public  Artista? RecuparPeloNome(string valorBusca)
    {

        return context.Artistas.FirstOrDefault(a => a.Nome.Equals(valorBusca));
    }
}
