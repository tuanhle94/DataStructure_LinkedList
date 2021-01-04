using System;
using System.Collections;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Midpoint function test cases
            var ls = new LinkedList<object>();
            ls.InsertLast('a');
            ls.InsertLast('b');
            ls.InsertLast('c');
            Console.WriteLine("Midpoint 1: {0}", Midpoint(ls).ToString());

            var ls2 = new LinkedList<object>();
            ls2.InsertLast('a');
            ls2.InsertLast('b');
            ls2.InsertLast('c');
            ls2.InsertLast('d');
            ls2.InsertLast('e');
            Console.WriteLine("Midpoint 2: {0}", Midpoint(ls2).ToString());

            var ls3 = new LinkedList<object>();
            ls3.InsertLast('a');
            ls3.InsertLast('b');
            Console.WriteLine("Midpoint 3: {0}", Midpoint(ls3).ToString());

            var ls4 = new LinkedList<object>();
            ls4.InsertLast('a');
            ls4.InsertLast('b');
            ls4.InsertLast('c');
            ls4.InsertLast('d');
            Console.WriteLine("Midpoint 4: {0}", Midpoint(ls4).ToString());

            // Circular function test cases
            var a = new Node<object>('a');
            var b = new Node<object>('b');
            var c = new Node<object>('c');

            var ls5 = new LinkedList<object>();
            ls5.Head = a;
            a.Next = b;
            b.Next = c;
            c.Next = b;
            Console.WriteLine("Boolean: {0}", Circular(ls5).ToString());

            var ls6 = new LinkedList<object>();
            ls6.Head = a;
            a.Next = b;
            b.Next = c;
            c.Next = a;
            Console.WriteLine("Boolean: {0}", Circular(ls6).ToString());

            var ls7 = new LinkedList<object>();
            ls7.Head = a;
            a.Next = b;
            b.Next = c;
            c.Next = null;
            Console.WriteLine("Boolean: {0}", Circular(ls7).ToString());

            // FromLast function test case
            var ls8 = new LinkedList<object>();
            ls8.InsertLast('a');
            ls8.InsertLast('b');
            ls8.InsertLast('c');
            ls8.InsertLast('d');
            ls8.InsertLast('e');
            Console.WriteLine("FromLast: {0}", FromLast(ls8, 3).ToString());

            // ReverseLinkedList function test case
            var ls9 = new LinkedList<object>();
            ls9.InsertLast('a');
            ls9.InsertLast('b');
            ls9.InsertLast('c');
            ls9.InsertLast('d');
            ls9.InsertLast('e');
            var result = ReverseLinkedList(ls9);
            var node = result.Head;
            Console.WriteLine("Reverse a linked list");

            while (node != null)
            {
                Console.WriteLine("{0}", node.Data.ToString());
                node = node.Next;
            }

        }

        // --- Directions
        // Return the 'middle' node of a linked list.
        // If the list has an even number of elements, return
        // the node at the end of the first half of the list.
        // *Do not* use a counter variable, *do not* retrieve
        // the size of the list, and only iterate
        // through the list one time.
        // --- Example
        //   const l = new LinkedList();
        //   l.insertLast('a')
        //   l.insertLast('b')
        //   l.insertLast('c')
        //   midpoint(l); // returns { data: 'b' }
        static object Midpoint(LinkedList<object> ls)
        {
            // create two temporary variables "slow" and "fast"
            var slow = ls.GetFirst();
            var fast = ls.GetFirst();

            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return slow.Data;
        }


        // --- Directions
        // Given a linked list, return true if the list
        // is circular, false if it is not.
        // --- Examples
        //   const l = new List();
        //   const a = new Node('a');
        //   const b = new Node('b');
        //   const c = new Node('c');
        //   l.head = a;
        //   a.next = b;
        //   b.next = c;
        //   c.next = b;
        //   circular(l) // true
        static bool Circular(LinkedList<object> ls)
        {
            // create two temporary variables "slow" and "fast"
            var slow = ls.GetFirst();
            var fast = ls.GetFirst();

            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                    return true;
            }

            return false;
        }

        // --- Directions
        // Given a linked list, return the element n spaces
        // from the last node in the list.  Do not call the 'size'
        // method of the linked list.  Assume that n will always
        // be less than the length of the list.
        // --- Examples
        //    const list = new List();
        //    list.insertLast('a');
        //    list.insertLast('b');
        //    list.insertLast('c');
        //    list.insertLast('d');
        //    fromLast(list, 2).data // 'b'
        static object FromLast(LinkedList<object> ls, int n)
        {
            // create two temporary variables "slow" and "fast"
            var slow = ls.GetFirst();
            var fast = ls.GetFirst();
            for (int i = 0; i < n; i++)
            {
                fast = fast.Next;
            }

            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }
            return slow.Data;
        }


        // Reverse a linked list using InsertFirst function
        static LinkedList<object> ReverseLinkedList(LinkedList<object> ls)
        {
            var result = new LinkedList<object>();
            var node = ls.Head;
            while (node != null)
            {
                result.InsertFirst(node.Data);
                node = node.Next;
            }
            return result;
        }
    }
}
