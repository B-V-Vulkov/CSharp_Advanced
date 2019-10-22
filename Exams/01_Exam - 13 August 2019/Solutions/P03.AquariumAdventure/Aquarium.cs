namespace AquariumAdventure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Aquarium
    {
        private Dictionary<string, Fish> fishInPool;
        private string name;
        private int capacity;
        private int size;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public int Size
        {
            get { return this.size; }
            private set { this.size = value; }
        }

        public Aquarium(string name, int capacity, int size)
        {
            this.fishInPool = new Dictionary<string, Fish>();
            this.Name = name;
            this.Capacity = capacity;
            this.Size = size;
        }

        public void Add(Fish fish)
        {
            if (!fishInPool.ContainsKey(fish.Name) && fishInPool.Count < capacity)
            {
                fishInPool.Add(fish.Name, fish);
            }
        }

        public bool Remove(string name)
        {
            bool isExists = false;

            if (fishInPool.ContainsKey(name))
            {
                fishInPool.Remove(name);
                isExists = true;
            }
            return isExists;
        }

        public Fish FindFish(string name)
        {
            Fish findFish = null;

            if (fishInPool.ContainsKey(name))
            {
                string color = fishInPool[name].Color;
                int fins = fishInPool[name].Fins;

                findFish = new Fish(name, color, fins);
            }
            return findFish;
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Aquarium: {Name} ^ Size: {Size}");

            foreach (var fish in fishInPool)
            {
                stringBuilder.Append(fish.Value + Environment.NewLine);
            }

            return stringBuilder.ToString().Trim();
        }
    }
}
