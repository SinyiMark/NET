using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Room
    {
        public int roomId { get; set; }

        public Room(int roomId)
        {
            this.roomId = roomId;
        }

        public Room()
        {
        }
    }
}
