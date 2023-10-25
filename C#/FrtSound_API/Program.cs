using System.Text.Json;
using FrtSound.Modelos;
using FrtSound.Filtros;

using (HttpClient client = new HttpClient())
{
    
    try
    {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    Console.WriteLine(resposta);
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

    LinqFilter.FiltrarMusicasEmCSharp(musicas);
    //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
    //LinqFilter.FiltrarArtistasPorGenerosMusical(musicas, "rock");
    // LinqFilter.FiltrarMusicasDeUmArtistas(musicas, "Michel Teló");
    var musicasPreferidasDoFreitas = new MusicasPreferidas("Freitas");   
    // musicasPreferidasDoFreitas.AdicionarMusicasFavoritas(musicas[1]); 
    // musicasPreferidasDoFreitas.AdicionarMusicasFavoritas(musicas[38]); 
    // musicasPreferidasDoFreitas.AdicionarMusicasFavoritas(musicas[10]); 
    // musicasPreferidasDoFreitas.AdicionarMusicasFavoritas(musicas[83]); 
    // musicasPreferidasDoFreitas.AdicionarMusicasFavoritas(musicas[1998]); 

    var musicasPreferidasDoDavi = new MusicasPreferidas("Davi");   
    musicasPreferidasDoDavi.AdicionarMusicasFavoritas(musicas[2]); 
    musicasPreferidasDoDavi.AdicionarMusicasFavoritas(musicas[39]); 
    musicasPreferidasDoDavi.AdicionarMusicasFavoritas(musicas[11]); 
    musicasPreferidasDoDavi.AdicionarMusicasFavoritas(musicas[84]); 
    musicasPreferidasDoDavi.AdicionarMusicasFavoritas(musicas[1999]); 

    musicasPreferidasDoDavi.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"temos um problema: {ex.Message}");
    }

}