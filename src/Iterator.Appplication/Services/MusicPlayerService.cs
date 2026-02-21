using Iterator.Domain.Enums;
using Iterator.Domain.Music.Entites;

namespace Iterator.Appplication.Services
{
    public class MusicPlayerService
    {
        private readonly Playlist _playlist;

        public MusicPlayerService(Playlist playlist)
        {
            _playlist = playlist;
        }

        public void Play(PlayerType? type = null, string? param = null)
        {
            var iterator = _playlist.CreateIterator(type, param);

            int count = 1;

            Console.WriteLine($"\n=== Tocando {_playlist.Name} ({type ?? PlayerType.Sequential}) ===");

            while (iterator.HasNext())
                Console.WriteLine($"{count++}. {iterator.Next()}");
        }
    }
}
