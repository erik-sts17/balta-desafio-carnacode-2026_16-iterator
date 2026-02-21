using Iterator.Domain.Abstractions;
using Iterator.Domain.Music.Entites;

namespace Iterator.Domain.ConcreteIterators
{
    public class GenreIterator : IIterator<Song>
    {
        private readonly List<Song> _filtered;
        private int _index;

        public GenreIterator(List<Song> songs, string genre)
        {
            _filtered = songs.Where(s => s.Genre == genre).ToList();
            _index = 0;
        }

        public bool HasNext()
            => _index < _filtered.Count;

        public Song Next()
            => _filtered[_index++];

        public void Reset()
            => _index = 0;
    }
}