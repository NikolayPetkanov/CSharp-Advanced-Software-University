﻿namespace P11_PokemonTrainer
{
    public class Pokemon
    {
        public string Name { get; set; }

        public string Element { get; set; }

        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }
}
