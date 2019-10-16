namespace P07.Tuple
{
    class Tuple<T, K>
    {
        public Tuple(T item1, K item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public T Item1 { get; private set; }

        public K Item2 { get; private set; }

        public override string ToString()
        {
            string result = this.Item1 + " -> " + this.Item2;
            return result;
        }
    }
}
