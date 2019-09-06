namespace P03.GenericSwapMethodString
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            boxCollection = new List<T>();
        }

        public void Add(T item)
        {
            boxCollection.Add(item);
        }

        public void Swap(int index1, int index2)
        {
            T currentElement = boxCollection[index1];
            boxCollection[index1] = boxCollection[index2];
            boxCollection[index2] = currentElement;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in boxCollection)
            {
                stringBuilder.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return stringBuilder.ToString();
        }
    }
}
