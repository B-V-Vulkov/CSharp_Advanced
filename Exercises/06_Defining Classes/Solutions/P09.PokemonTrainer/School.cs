namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class School
    {
        private List<Trainer> trainers;

        public List<Trainer> Trainers
        {
            get { return this.trainers; }
        }

        public School()
        {
            this.trainers = new List<Trainer>();
        }

        public bool IsTrainerExist(string trainerName)
        {
            string name = trainers
                .Select(n => n.Name)
                .Where(n => n == trainerName)
                .FirstOrDefault();

            return name != null;
        }

        public void AddTrainer(Trainer trainer)
        {
            this.trainers.Add(trainer);
        }

        public Trainer GetTrainer(string name)
        {
            return trainers
                .FirstOrDefault(n => n.Name == name);
        }

        public List<Trainer> GetTrainersIsContentElement(string element)
        {
            List<Trainer> contentElement = new List<Trainer>();

            foreach (var trainer in trainers)
            {
                foreach (var pokemon in trainer.Pokemons)
                {
                    if (pokemon.Element == element)
                    {
                        contentElement.Add(trainer);
                        break;
                    }
                }
            }

            return contentElement;
        }

        public List<Trainer> GetTrainersIsNotContentElement(string element)
        {
            List<Trainer> notContentElement = new List<Trainer>();

            foreach (var trainer in trainers)
            {
                bool isNotContent = true;

                foreach (var pokemon in trainer.Pokemons)
                {
                    if (pokemon.Element == element)
                    {
                        isNotContent = false;
                        break;
                    }
                }
                if (isNotContent)
                {
                    notContentElement.Add(trainer);
                }
            }

            return notContentElement;
        }

        public void Print()
        {
            trainers = trainers
                .OrderByDescending(b => b.Badges)
                .ToList();

            foreach (var trainer in trainers)
            {
                Console.Write($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
                Console.WriteLine();
            }
        }
    }
}
