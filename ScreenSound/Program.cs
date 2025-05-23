﻿using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Modelos;


#region Teste com metodos DAL
//try
//{
//    var context = new ScreenSoundContext();
//    var artistaDAL = new ArtistaDal(context);

//    //var novoArtista = new Artista("Menino Maluquinho", "Mil Grau");
//    var novoArtista = new Artista("Jamily", "Mil Grauuuuu") { Id= 1003};
//    //artistaDAL.Deletar(novoArtista);

//    //artistaDAL.Adcionar(novoArtista);
//    //artistaDAL.Atualizar(novoArtista);
//    var listaArtistas = artistaDAL.Listar();

//    var teste = artistaDAL.RecuparPeloNome( "teste");
//    if( teste != null)
//    {
//        Console.WriteLine(teste);

//    } 
//    else
//    {
//        Console.WriteLine("Não foi achado nenhum artista no banco com esse nome");
//    }
//    //foreach (var artista in teste)
//    //{
//    //    Console.WriteLine(artista);
//    //}

//}
//catch (Exception ex)
//{

//    Console.WriteLine($"Ocorreu um [ERRO]: {ex.Message}");
//}
//return;
#endregion

var context = new ScreenSoundContext();
var artistaDAL = new DAL<Artista>(context);

//

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarArtista());
opcoes.Add(2, new MenuRegistrarMusica());
opcoes.Add(3, new MenuMostrarArtistas());
opcoes.Add(4, new MenuMostrarMusicas());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para registrar a música de um artista");
    Console.WriteLine("Digite 3 para mostrar todos os artistas");
    Console.WriteLine("Digite 4 para exibir todas as músicas de um artista");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(artistaDAL);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();