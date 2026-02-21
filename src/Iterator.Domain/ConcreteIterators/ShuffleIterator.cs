using Iterator.Domain.Abstractions;
using Iterator.Domain.Music.Entites;

namespace Iterator.Domain.ConcreteIterators
{
    public class ShuffleIterator : IIterator<Song>
    {
        private readonly List<Song> _shuffled;
        private int _index;

        public ShuffleIterator(List<Song> songs)
        {
            var random = new Random();
            _shuffled = songs.OrderBy(x => random.Next()).ToList();
            _index = 0;
        }

        public bool HasNext()
            => _index < _shuffled.Count;

        public Song Next()
            => _shuffled[_index++];

        public void Reset()
            => _index = 0;
    }
}
