using Iterator.Appplication.Services;
using Iterator.Domain.Enums;
using Iterator.Domain.Music.Entites;

var playlist = new Playlist("Minhas Favoritas");

playlist.AddSong(new Song("Bohemian Rhapsody", "Queen", "Rock", 354, 1975));
playlist.AddSong(new Song("Imagine", "John Lennon", "Pop", 183, 1971));
playlist.AddSong(new Song("Smells Like Teen Spirit", "Nirvana", "Rock", 301, 1991));
playlist.AddSong(new Song("Billie Jean", "Michael Jackson", "Pop", 294, 1982));

var player = new MusicPlayerService(playlist);

player.Play();                  // Sequencial
player.Play(PlayerType.Shuffle);         // Aleatório
player.Play(PlayerType.Genre, "Rock");   // Por gênero