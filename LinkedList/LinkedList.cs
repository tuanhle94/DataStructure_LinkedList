using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    /// <summary>
    /// Linked list class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedList<T>
    {
        private Node<T> head;

        /// <summary>
        /// Head property
        /// </summary>
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

        /// <summary>
        /// Constructor
        /// </summary>
        public LinkedList()
        {
            head = null;
        }

        /// <summary>
        /// Creates a new Node from argument 'data' and assigns the resulting node to the 'head' property
        /// </summary>
        /// <param name="data">the data to be inserted</param>
        public void InsertFirst(object data)
        {
            var node = new Node<T>(data, this.head);
            head = node;
        }

        /// <summary>
        /// Gets the size of the linked list
        /// </summary>
        /// <returns>Returns the number of nodes in the linked list.</returns>
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

        /// <summary>
        /// Gets the first node of the linked list
        /// </summary>
        /// <returns>Returns the first node of the linked list.</returns>
        public Node<T> GetFirst()
        {
            return head;
        }

        /// <summary>
        /// Gets the last node of the linked list
        /// </summary>
        /// <returns>Returns the last node of the linked list</returns>
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

        /// <summary>
        /// Empties the linked list of any nodes.
        /// </summary>
        public void Clear()
        {
            head = null;
        }

        /// <summary>
        /// Removes only the first node of the linked list. 
        /// The list's head should now be the second element.
        /// </summary>
        public void RemoveFirst()
        {
            if (head == null)
                return;
            else
                head = head.Next;
        }

        /// <summary>
        /// Removes the last node of the chain
        /// </summary>
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

        /// <summary>
        /// Inserts a new node with provided data at the end of the chain
        /// </summary>
        /// <param name="data">the data to be inserted</param>
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

        /// <summary>
        /// Gets the node at the provided index
        /// </summary>
        /// <param name="index">the index to get the node at</param>
        /// <returns>Returns the node at the provided index</returns>
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

        /// <summary>
        /// Removes node at the provided index
        /// </summary>
        /// <param name="index">the index of the node to be removed</param>
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

        /// <summary>
        /// Create an insert a new node at provided index. 
        /// If index is out of bounds, add the node to the end of the list.	
        /// </summary>
        /// <param name="data"> the data to be inserted</param>
        /// <param name="index"> the index where the new node is inserted at</param>
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

    /// <summary>
    /// Node class
    /// </summary>
    /// <typeparam name="T"></typeparam>
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



