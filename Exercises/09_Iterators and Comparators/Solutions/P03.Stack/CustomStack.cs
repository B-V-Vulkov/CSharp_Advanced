using System;

namespace P03.Stack
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomStack<T> : IEnumerable<T>
    {
        private const int initializedSize = 2;

        private T[] innerArray;

        private int pointer;

        public CustomStack()
        {
            this.innerArray = new T[initializedSize];
            this.pointer = -1;
        }

        public void Push(T element)
        {
            this.pointer++;

            if (this.innerArray.Length == this.pointer)
            {
                this.IncreaseArraySize();
            }

            this.innerArray[pointer] = element;
        }

        public T Pop()
        {
            if (this.pointer < 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T result = innerArray[pointer];
            this.pointer--;
            return result;
        }

        private void IncreaseArraySize()
        {
            var copyArray = new T[this.innerArray.Length * 2];

            for (int i = 0; i < this.pointer; i++)
            {
                copyArray[i] = this.innerArray[i];
            }

            this.innerArray = copyArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.pointer; i >= 0; i--)
            {
                yield return this.innerArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
