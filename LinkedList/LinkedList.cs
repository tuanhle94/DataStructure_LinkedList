using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node<T> head;

        public Node<T> Head
        {
            get
            {
                return head;

            }
            set
            {
                head = value;
            }
        }
        public LinkedList()
        {
            head = null;
        }

        public void InsertFirst(object data)
        {
            var node = new Node<T>(data, this.head);
            head = node;
        }

        public int Size()
        {
            int counter = 0;
            var node = head;

            while (node != null)
            {
                counter++;
                node = node.Next;
            }
            return counter;
        }

        public Node<T> GetFirst()
        {
            return head;
        }

        public Node<T> GetLast()
        {

            var node = head;

            if (node == null)
            {
                return null;
            }

            while (node.Next != null)
            {
                node = node.Next;
            }
            return node;
        }

        public void Clear()
        {
            head = null;
        }

        public void RemoveFirst()
        {
            if (head == null)
                return;
            else
                head = head.Next;
        }

        public void RemoveLast()
        {
            if (head == null)
                return;
            else if (head.Next == null)
            {
                head = null;
            }
            else
            {
                var previousNode = head;
                var node = head.Next;

                while (node.Next != null)
                {
                    previousNode = node;
                    node = node.Next;
                }
                previousNode.Next = null;
            }
        }

        public void InsertLast(object data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
            }
            else
            {
                var last = GetLast();
                last.Next = new Node<T>(data);
            }
        }

        public Node<T> GetAt(int index)
        {
            int counter = 0;
            var node = head;
            while (node != null)
            {
                if (counter == index)
                {
                    return node;
                }
                counter++;
                node = node.Next;
            }
            return null;
        }

        public void RemoveAt(int index)
        {
            if (head == null)
            {
                return;
            }

            if (index == 0)
            {
                head = head.Next;
                return;
            }

            var previousNode = GetAt(index - 1);
            if (previousNode == null | previousNode.Next == null)
                return;
            previousNode.Next = previousNode.Next.Next;
        }

        public void InsertAt(object data, int index)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                return;
            }

            if (index == 0)
            {
                head = new Node<T>(data, head);
                return;
            }

            var previousNode = GetAt(index - 1);
            if (previousNode == null)
            {
                previousNode = GetLast();
            }
            var node = new Node<T>(data, previousNode.Next);
            previousNode.Next = node;
        }
    }

    public class Node<T>
    {
        private object data;
        private Node<T> next;

        public object Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public Node<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public Node(object data, Node<T> next = null)
        {
            this.data = data;
            this.next = next;
        }
    }
}



