namespace FrtSound.Modelos;
using System.Text.Json;

internal class MusicasPreferidas
{
    public string? Nome {get; set;} 
    public List<Musica> ListaDeMusicasFavoritas{get;}

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }
    public void ExibirMusicafavoritas()
    {
        Console.WriteLine($"Essas sao as musicas favoritas > {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"-{musica.Nome} de {musica.Artista}");
            
        }

    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas,
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo json foi criado {Path.GetFullPath(nomeDoArquivo)}");
    }

}