using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;
// Usamos o where para dizer que o T vai representar uma class
internal class DAL<T> where T : class
{
    protected readonly ScreenSoundContext context;

    // Contrutor solicitando context
    protected DAL(ScreenSoundContext context)
    {
        this.context = context;
    }


    // Metodo listar musicas
    public IEnumerable<T> Listar()
    {
        // Usamos o generic Set para pegar o tpo da class  que estamos ultiliazando ao chamar o metodo
        return context.Set<T>().ToList();
    }

    // Metodo Adiconar Musica
    public void Adicionar(T objeto)
    {
        context.Set<T>().Add(objeto);
        context.SaveChanges();
    }

    //Metodo atualizar musicas
    public void Atualizar(T objeto)
    {
        context.Set<T>().Update(objeto);
        context.SaveChanges();
    }

    // Metodo Deletar musica
    public void Deletar(T objeto)
    {
        context.Set<T>().Remove(objeto);
        context.SaveChanges();
    }

    //Metodo RecuperarPor
    public T? RecuparPeloNome(Func<T, bool> condicao)
    {
        return context.Set<T>().FirstOrDefault(condicao);
    }






}

