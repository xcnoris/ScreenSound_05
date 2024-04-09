using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class ConexaoBD
{
    private string stringDeConexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
    
    public SqlConnection ObeterConexao()
    {
        return new SqlConnection(stringDeConexao);
    }
    public IEnumerable<Artista> Listar()
    {
        var lista = new List<Artista>();
        using var connection = ObeterConexao();
        connection.Open();

        string comando = "select * from Artistas";
        SqlCommand consulta = new SqlCommand(comando, connection);
        using SqlDataReader dataReader = consulta.ExecuteReader();

        while (dataReader.Read())
        {
            string nomeArtista = Convert.ToString(dataReader["Nome"]);
            string bioArtista = Convert.ToString(dataReader["Bio"]);
            int idArtista = Convert.ToInt32(dataReader["Id"]);
            Artista artista = new(nomeArtista, bioArtista) { Id = idArtista };

            lista.Add(artista);
        }
        return lista;

    }


}
