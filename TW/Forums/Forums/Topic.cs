using System.Collections.Generic;

namespace Forums
{
    public class Topic:Entry
    {
        public string Title { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();
        private static int idCounter { get; set; } = 1;

        public Topic(string message, string title) : base(message)
        {
            Id = idCounter;
            idCounter++;
            this.Title = title;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public override string ToString()
        {
            string text = $"{Id} {Title} {Message} \n";
            foreach (var comment in Comments)
            {
                text = text + "    Comments:\n    "+ comment.ToString() + "\n";
            }
            return text;
        }
    }
}