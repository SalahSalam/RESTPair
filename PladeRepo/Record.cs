namespace RecordRepo
{
    public class Record
    {
        public int Id { get; set; }
        public string Title { get; private set; }
        public string Artist { get; private set; }
        public double Duration { get; private set; }
        public int PublicationYear { get; private set; }

        public Record()
        {

        }
        public Record(string title, string artist, double duration, int publicationYear)

        {
            Title = title;
            Artist = artist;
            Duration = duration;
            PublicationYear = publicationYear;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Artist: {Artist}, Duration: {Duration}, Publication Year: {PublicationYear}";
        }

    }
}
