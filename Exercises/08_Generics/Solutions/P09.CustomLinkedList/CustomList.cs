namespace CustomList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomList<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 2;

        private T[] items;

        public CustomList()
        {
            this.items = new T[InitialCapacity];
            this.Count = 0;
        }

        public CustomList(int capacity)
            : base()
        {
            this.items = new T[capacity];
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.Count = collection.Count();
            this.items = collection.ToArray();
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                ValidateIndex(index);
                return items[index];
            }
            set
            {
                ValidateIndex(index);
                this.items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.items.Length == this.Count)
            {
                Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            this.ValidateIndex(index);

            T element = this.items[index];

            this.Shift(index);

            this.Count--;

            this.Shrink();

            return element;
        }

        public bool Remove(T item)
        {
            int index = this.IndexOf(item);

            if (index == -1)
            {
                return false;
            }

            this.Shift(index);

            this.Count--;

            this.Shrink();

            return true;
        }

        public void Clear()
        {
            this.items = new T[InitialCapacity];
            this.Count = 0;
        }

        public int IndexOf(T item)
        {
            int index = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Equals(item))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public void Insert(int index, T item)
        {
            this.ValidateIndex(index);

            if (this.items.Length == this.Count)
            {
                Resize();
            }

            for (int i = Count; i > index; i--)
            {
                this.items[i] = this.items[i - 1];
            }

            this.items[index] = item;
            this.Count++;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);

            T currentElement = this.items[firstIndex];

            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = currentElement;
        }

        public bool Contains(T element)
        {
            if (this.Count == 0)
            {
                return false;
            }

            bool isContains = false;

            for (int i = 0; i < this.items.Length; i++)
            {
                if (this.items[i].Equals(element))
                {
                    isContains = true;
                    break;
                }
            }

            return isContains;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void Shrink()
        {
            if (this.Count * 4 >= this.items.Length)
            {
                return;
            }

            T[] copy = new T[this.items.Length / 2];

            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.items[Count - 1] = default(T);
        }

        private void Resize()
        {
            T[] copy = new T[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }
    }
}