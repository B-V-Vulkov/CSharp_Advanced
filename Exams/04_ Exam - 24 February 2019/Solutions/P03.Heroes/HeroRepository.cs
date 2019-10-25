namespace Heroes
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HeroRepository
    {
        private ICollection<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count
        {
            get { return this.data.Count; }
        }

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name) 
        {
            var hero = this.data
                .FirstOrDefault(n => n.Name == name);

            this.data.Remove(hero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            var hero = this.data
               .OrderByDescending(x => x.Item.Strength)
               .FirstOrDefault();

            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            var hero = this.data
               .OrderByDescending(x => x.Item.Ability)
               .FirstOrDefault();

            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            var hero = this.data
               .OrderByDescending(x => x.Item.Intelligence)
               .FirstOrDefault();

            return hero;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var hero in data)
            {
                stringBuilder.AppendLine($"{hero.ToString()}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
