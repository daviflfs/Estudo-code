using System.Linq;
using FrtSound.Modelos;

namespace FrtSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistasPorGenerosMusical(List<Musica> musicas, string genero)
    {
        var artistaPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical");
        foreach(var artista in artistaPorGeneroMusical )
        {
            Console.WriteLine($"-{artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtistas(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in musicasDoArtista )
        {
            Console.WriteLine($"-{musica.Nome}");
        }
    }
     internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas
        .Where(Musica => Musica.Tonalidade.Equals("C#"))
        .Select(musica => musica.Nome)
        .ToList();
        Console.WriteLine("Musicas em C#");
        foreach(var musica  in musicasEmCSharp )
        {
            Console.WriteLine($"{musica}");
        }
    }

}