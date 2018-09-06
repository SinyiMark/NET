using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedLIst
    {
        public Node Head { get; set; }
        public Node Last { get; set; }
        public int Lenght { get; set; }

        public LinkedLIst()
        {
            Head = null;
            Last = null;
            Lenght = 0;
        }

        public void Add(object data)
        {
            if (Head == null)
            {
                Head = new Node(data);
                Last = Head;
            }
            else
            {
                Last.Next = new Node(data);
            }
            Lenght++;
        }

        public object Get(int index) {
            if (index > Lenght)
            {
                throw new IndexOutOfRangeException();
            }
            Node CurrentNode = Head;
            for (int i = 0; i < index; i++)
            {
                if (i != 0)
                {
                    CurrentNode = CurrentNode.Next;
                }
            }
            return CurrentNode.Data;
        }

        public Node GetNode(int index)
        {
            if (index > Lenght)
            {
                throw new IndexOutOfRangeException();
            }
            Node CurrentNode = Head;
            for (int i = 0; i < index; i++)
            {
                if (i != 0)
                {
                    CurrentNode = CurrentNode.Next;
                }
            }
            return CurrentNode;
        }

        public void Remove(int index) 
        {
            Node PreviousNode = GetNode(index - 1);
            PreviousNode.Next = PreviousNode.Next.Next;
            Lenght--;
        }

        public void Insert(int index, object data)
        {
            Node PreviousNode = GetNode(index - 1);
            Node NewNode = new Node(data);
            NewNode.Next = PreviousNode.Next;
            PreviousNode.Next = NewNode;
            Lenght++;
        }
    }
}
