namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public string Name
        {
            get { return this.name; }
        }

        public string Element
        {
            get { return this.element; }
        }

        public int Health
        {
            get { return this.health; }
        }

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }

        public void DecreaseHealth()
        {
            this.health -= 10;
        }
    }
}
