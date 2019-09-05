namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string command = string.Empty;

            School school = new School();

            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] splittedCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = splittedCommand[0];
                string pokemonName = splittedCommand[1];
                string pokemonElement = splittedCommand[2];
                int pokemonHealth = int.Parse(splittedCommand[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName);

                if (!school.IsTrainerExist(trainerName))
                {
                    school.AddTrainer(trainer);
                }

                school.GetTrainer(trainerName).AddPokemon(pokemon);
            }

            while ((command = Console.ReadLine()) != "End")
            {
                List<Trainer> isContentElement = school.GetTrainersIsContentElement(command);
                List<Trainer> isNotContentElement = school.GetTrainersIsNotContentElement(command);

                foreach (var trainer in isContentElement)
                {
                    trainer.IncreaseBadges();
                }

                foreach (var trainer in isNotContentElement)
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.DecreaseHealth();
                    }

                    trainer.RemoveDeadPokemons();
                }
            }

            school.Print();

        }
    }
}
