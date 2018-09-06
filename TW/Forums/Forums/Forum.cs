using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forums
{
    class Forum
    {
        public List<Topic> Topics { get; set; } = new List<Topic>();
        private static Forum Instance { get; set; }

        private Forum()
        {
        }

        public static Forum GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Forum();
            }
            return Instance;
        }

        public void AddTopic(Topic topic)
        {
            Topics.Add(topic);
        }

        public override string ToString()
        {
            string text = "Topics:\n";
            foreach (var topic in Topics)
            {
                text = text + topic.ToString();
            }
            return text;
        }
    }
}
