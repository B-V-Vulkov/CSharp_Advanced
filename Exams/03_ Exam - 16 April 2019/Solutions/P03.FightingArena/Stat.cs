namespace FightingArena
{
    public class Stat
    {
        public Stat(int strength, int flexibility, int agility, int skills, int intelligence)
        {
            this.Strength = strength;
            this.Flexibility = flexibility;
            this.Agility = agility;
            this.Skills = skills;
            this.Intelligence = intelligence;
        }

        public int Strength { get; }

        public int Flexibility { get; }

        public int Agility { get; }

        public int Skills { get; }

        public int Intelligence { get; }
    }
}
