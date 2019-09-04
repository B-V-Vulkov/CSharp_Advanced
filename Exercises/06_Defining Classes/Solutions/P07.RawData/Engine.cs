namespace DefiningClasses
{
    public class Engine
    {
        private int speed;
        private int power;

        public int Speed
        {
            get { return this.speed; }
        }

        public int Power
        {
            get { return this.power; }
        }

        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }
    }
}
