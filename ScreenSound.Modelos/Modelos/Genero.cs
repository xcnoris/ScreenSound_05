﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos.Modelos;

public class Genero
{
    public int Id { get; set; }
    public string? Nome { get; set; } = string.Empty;
    public string? Descricao { get; set; } = string.Empty;

    // usamos o virtual para que o entity framework posso manipular nossa propriedade 
    public virtual ICollection<Musica>? Musicas { get; set; }

    public override string ToString()
    {
        return $"Nome: {Nome} - Descrição: {Descricao}";
    }
}
