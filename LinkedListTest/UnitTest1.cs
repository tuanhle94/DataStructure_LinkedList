using System;
using Xunit;
using LinkedList;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void InsertFirstTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertFirst(5);
            Assert.Equal(5, list.Head.Data);

            list.InsertFirst(2);
            Assert.Equal(2, list.Head.Data);
        }

        [Fact]
        public void SizeTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertFirst(5);
            list.InsertFirst(2);

            Assert.Equal(3, list.Size());
        }

        [Fact]
        public void GetFirstTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertFirst(5);
            list.InsertFirst(2);

            Assert.Equal(2, list.GetFirst().Data);
        }

        [Fact]
        public void GetLastTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertFirst(5);
            list.InsertFirst(2);

            Assert.Equal(1, list.GetLast().Data);
        }

        [Fact]
        public void ClearTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertFirst(5);
            list.InsertFirst(2);
            list.Clear();

            Assert.Equal(0, list.Size());
        }

        [Fact]
        public void RemoveFirstTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertFirst(5);
            list.InsertFirst(2);
            list.InsertFirst(7);
            list.RemoveFirst();

            Assert.Equal(2, list.GetFirst().Data);

            list.RemoveFirst();
            Assert.Equal(5, list.GetFirst().Data);
        }


        [Fact]
        public void RemoveLastTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertFirst(5);
            list.InsertFirst(2);
            list.InsertFirst(7);

            list.RemoveLast();
            Assert.Equal(5, list.GetLast().Data);

            list.RemoveLast();
            Assert.Equal(2, list.GetLast().Data);

            var node2 = new Node<int>(1);
            var list2 = new LinkedList<int>
            {
                Head = node2
            };

            list2.RemoveLast();
            Assert.Null(list2.Head);
        }

        [Fact]
        public void InsertLastTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertLast(5);
            list.InsertLast(2);

            Assert.Equal(2, list.GetLast().Data);

            list.RemoveLast();
            Assert.Equal(5, list.GetLast().Data);
        }

        [Fact]
        public void GetAtTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertLast(5);
            list.InsertLast(2);

            Assert.Equal(1, list.GetAt(0).Data);
            Assert.Equal(5, list.GetAt(1).Data);
            Assert.Equal(2, list.GetAt(2).Data);
            Assert.Null(list.GetAt(8));
        }


        [Fact]
        public void RemoveAtTest()
        {
            var node1 = new Node<int>(1);
            var list = new LinkedList<int>
            {
                Head = node1
            };

            list.InsertLast(5);
            list.InsertLast(2);
            list.InsertLast(4);
            list.InsertLast(8);

            Assert.Equal(1, list.GetAt(0).Data);
            list.RemoveAt(0);
            Assert.Equal(5, list.GetAt(0).Data);

            Assert.Equal(4, list.GetAt(2).Data);
            list.RemoveAt(2);
            Assert.Equal(8, list.GetAt(2).Data);


            list.InsertLast(6);
            Assert.Equal(6, list.GetAt(3).Data);
            list.RemoveAt(3);
            Assert.Null(list.GetAt(3));
        }

        [Fact]
        public void InsertAtTest()
        {
            var list = new LinkedList<int>();

            list.InsertAt(4, 0);

            Assert.Equal(4, list.GetAt(0).Data);

            list.InsertLast(5);
            list.InsertLast(2);
            list.InsertLast(4);
            list.InsertLast(8);

            list.InsertAt(54, 2);
            Assert.Equal(54, list.GetAt(2).Data);

            list.InsertAt(22, 6);
            Assert.Equal(22, list.GetAt(6).Data);

            list.InsertAt(22, 323);
            Assert.Equal(22, list.GetLast().Data);
        }
    }
}
