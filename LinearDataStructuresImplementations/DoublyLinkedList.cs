using System;
using System.Collections;
using System.Collections.Generic;

namespace LinearDataStructuresImplementations
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private Node root;
        private Node last;

        public DoublyLinkedList()
        {
            this.root = null;
            this.last = null;
        }

        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }

            public Node Next { get; set; }

            public Node Previous { get; set; }
        }

        public void AddLast(T value)
        {
            if (this.root == null)
            {
                this.last = this.root = new Node(value);
            }
            else if (this.root == this.last)
            {
                this.last = new Node(value);
                this.root.Next = last;
                this.last.Previous = root;
                this.last.Next = null;
            }
            else
            {
                var newNode = new Node(value);
                newNode.Previous = last;
                this.last.Next = newNode;
                this.last = newNode;
            }
        }

        public void AddFirst(T value)
        {
            if (this.root == null)
            {
                this.last = this.root = new Node(value);
            }
            else if (this.root == this.last)
            {
                this.root = new Node(value);
                this.root.Next = last;
                this.last.Previous = root;
                this.last.Next = null;
            }
            else
            {
                var newNode = new Node(value);
                newNode.Previous = null;
                this.root.Previous = newNode;
                this.root = newNode;
            }
        }

        public T RemoveFirst()
        {
            T value;
            
            if (this.root == null)
            {
                throw new ArgumentException("List is empty!");
            }
            else if (this.root == this.last)
            {
                value = this.root.Value;
                this.root = this.last = null;
                return value;
            }

            value = this.root.Value;
            this.root = this.root.Next;
            this.root.Previous = null;
            return value;
        }

        public T RemoveLast()
        {
            T value;

            if (this.root == null)
            {
                throw new ArgumentException("List is empty!");
            }
            else if (this.root == this.last)
            {
                value = this.last.Value;
                this.root = this.last = null;
                return value;
            }

            value = this.last.Value;
            this.last = this.last.Previous;
            this.last.Next = null;
            return value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.root;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
