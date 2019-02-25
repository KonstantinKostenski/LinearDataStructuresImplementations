using System;
using System.Collections;
using System.Collections.Generic;

namespace LinearDataStructuresImplementations
{
    public class LinkedStack<T> : IEnumerable<T>
    {
        private Node topNode;
        private int nodeNumber;

        private class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }

            public T Value { get; set; }
            public Node Previous { get; set; }
        }

        public void Push (T value)
        {
            if (this.topNode == null)
            {
                this.topNode = new Node(value);
                this.nodeNumber++;
            }
            else
            {
                var temp = this.topNode;
                this.topNode = new Node(value);
                this.topNode.Previous = temp;
                this.nodeNumber++;
            }
        }

        public T Pop()
        {
            if (this.topNode == null)
            {
                throw new ArgumentException();
            }

            var value = this.topNode.Value;
            var temp = this.topNode;
            this.topNode = this.topNode.Previous;
            this.nodeNumber--;
            return value;
        }


        public T[] ToArray()
        {
            var current = this.topNode;
            int index = 0;
            T[] array = new T[this.nodeNumber];

            while (current != null)
            {
                array[index++] = current.Value;
                current = current.Previous;
            }

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.topNode;

            while (current != null)
            {
                yield return current.Value;
                current = current.Previous;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
