using Iterator.Domain.Abstractions;
using Iterator.Domain.Music.Entites;

namespace Iterator.Domain.ConcreteIterators
{
    public class SequentialIterator : IIterator<Song>
    {
        private readonly List<Song> _songs;
        private int _index;

        public SequentialIterator(List<Song> songs)
        {
            _songs = songs;
            _index = 0;
        }

        public bool HasNext()
            => _index < _songs.Count;

        public Song Next()
            => _songs[_index++];

        public void Reset()
            => _index = 0;
    }
}