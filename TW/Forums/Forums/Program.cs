using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forums
{
    class Program
    {
        static void Main(string[] args)
        {
            var myForum = Forum.GetInstance();
            myForum.AddTopic(new Topic("asd", "first"));
            myForum.Topics[0].AddComment(new Comment("First asdas"));
            Console.WriteLine(myForum.ToString());
        }
    }
}
