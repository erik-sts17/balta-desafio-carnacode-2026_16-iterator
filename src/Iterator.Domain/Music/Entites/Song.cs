namespace Iterator.Domain.Music.Entites
{
    public  class Song
    {
        public string Title { get; }
        public string Artist { get; }
        public string Genre { get; }
        public int DurationSeconds { get; }
        public int Year { get; }

        public Song(string title, string artist, string genre, int duration, int year)
        {
            Title = title;
            Artist = artist;
            Genre = genre;
            DurationSeconds = duration;
            Year = year;
        }

        public override string ToString()
            => $"{Title} - {Artist} ({Genre}, {Year})";
    }
}