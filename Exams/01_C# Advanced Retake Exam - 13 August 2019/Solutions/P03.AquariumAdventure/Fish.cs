namespace AquariumAdventure
{
    using System;

    public class Fish
    {
        private string name;
        private string color;
        private int fins;

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Color
        {
            get { return this.color; }
            private set { this.color = value; }
        }

        public int Fins
        {
            get { return this.fins; }
            private set { this.fins = value; }
        }

        public Fish(string name, string color, int fins)
        {
            this.Name = name;
            this.Color = color;
            this.Fins = fins;
        }

        public override string ToString()
        {
            return $"Fish: {this.name}" + Environment.NewLine +
                $"Color: {this.color}" + Environment.NewLine +
                $"Number of fins: {this.fins}";
        }
    }
}
