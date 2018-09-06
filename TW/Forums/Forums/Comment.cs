namespace Forums
{
    public class Comment : Entry
    {
        public bool Moderated { get; set; } = false;
        private int idCounter { get; set; } = 1;

        public Comment(string message) : base(message)
        {
            Id = idCounter;
            idCounter++;
        }

        public void TogleModeration()
        {
            Moderated = true;
        }

        public override string ToString()
        {
            return $"{Id} {Message}";
        }
    }
}