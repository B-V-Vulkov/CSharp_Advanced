namespace FightingArena
{
    public class Weapon
    {
        public Weapon(int size, int solidity, int sharpness)
        {
            this.Size = size;
            this.Solidity = solidity;
            this.Sharpness = sharpness;
        }

        public int Size { get; }

        public int Solidity { get; }

        public int Sharpness { get; }
    }
}
