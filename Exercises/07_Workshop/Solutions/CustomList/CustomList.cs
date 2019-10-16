namespace CustomList
{
    using System;

    public class CustomList
    {
        private const int InitialCapacity = 2;

        private int[] items;

        public CustomList()
        {
            this.items = new int[InitialCapacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public int this[int index]
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

        public void Add(int item)
        {
            if (this.items.Length == this.Count)
            {
                Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public int RemoveAt(int index)
        {
            this.ValidateIndex(index);

            int element = this.items[index];

            this.Shift(index);

            this.Count--;

            this.Shrink();

            return element;
        }

        public void Insert(int index, int item)
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
        }

        public void Swap(int firstIndex, int secondIndex) 
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);

            int currentElement = this.items[firstIndex];

            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = currentElement;
        }

        public bool Contains(int element) 
        {
            bool isContains = false;

            for (int i = 0; i < this.items.Length; i++)
            {
                if (this.items[i] == element)
                {
                    isContains = true;
                    break;
                }
            }

            return isContains;
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

            int[] copy = new int[this.items.Length / 2];

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

            this.items[Count - 1] = default(int);
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }
    }
}
