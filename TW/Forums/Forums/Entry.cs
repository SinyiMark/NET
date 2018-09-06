using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forums
{
    public abstract class Entry
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreationDate { get; set; }

        public Entry(string message)
        {
            Message = message;
        }

        public abstract override string ToString();
    }
}
