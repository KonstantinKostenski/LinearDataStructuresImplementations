using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedListImplementation
{
    public class ArrayStack<T> : IEnumerable<T>
    {
        private T[] array;
        private int count = 0;
        private int defaultInitialSize = 4;

        //Empty constructor with default initial array size.
        public ArrayStack()
        {
            this.array = new T[defaultInitialSize];
        }

        //Constructor that allows for a custom array size.
        public ArrayStack(int size)
        {
            this.array = new T[size];
        }

        //Adding values on the stack.
        public void Push(T value)
        {
            if (this.count == this.array.Length)
            {
                //Doubling the size of the area if its limit is reached.
                ResizeArray();
            }

            this.array[count] = value;
            this.count++;
        }

        //Removing items from teh stack.
        public T Pop()
        {
            if (this.count <= this.array.Length / 2)
            {
                //Shrinking the area id the count of elements is below or equal to a certain treshold.
                ShrinkArray();
            }

            this.count--;
            T value = this.array[count];
            this.array[count] = default(T);
            return value;
        }

        private void ShrinkArray()
        {
            var newArray = new T[this.array.Length / 2];

            for (int i = 0; i < this.array.Length / 2; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        private void ResizeArray()
        {
            var newArray = new T[this.array.Length * 2];

            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.count - 1; i >= 0; i--)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
