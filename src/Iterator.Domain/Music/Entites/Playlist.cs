using Iterator.Domain.Abstractions;
using Iterator.Domain.ConcreteIterators;
using Iterator.Domain.Enums;

namespace Iterator.Domain.Music.Entites
{
    public class Playlist : IAggregate<Song>
    {
        private readonly List<Song> _songs = [];

        public string Name { get; }

        public Playlist(string name)
        {
            Name = name;
        }

        public void AddSong(Song song)
        {
            _songs.Add(song);
        }

        public IIterator<Song> CreateIterator(PlayerType? type, string? param = null)
        {
            return type switch
            {
                PlayerType.Shuffle => new ShuffleIterator(_songs),
                PlayerType.Genre => new GenreIterator(_songs, param ?? ""),
                _ => new SequentialIterator(_songs),
            };
        }
    }
}
