﻿using System;

namespace OOPCalances
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created.");
            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("woof-woof");
                happiness += 0.2;
            }

            public void Wiggle()
            {
                Console.WriteLine("wiggle-wiggle");
            }

            public void Rename(string newName)
            {
                name = newName;
            }

            public void ShowDogData()
            {
                Console.WriteLine($"Name: {name}; Spots: {spots}; happy: {happiness};");
            }
        }
        static void Main(string[] args)
        {
            Dog newDog = new Dog("Koer", 10);
            Console.WriteLine($"the level of happinness: {newDog.Happiness}");
            
            while(newDog.Happiness != 1)
            {
                newDog.Barks();
            }

            newDog.Wiggle();
            Console.WriteLine("Name the dog:");
            string newDogName = Console.ReadLine();
            newDog.Rename(newDogName);
            newDog.ShowDogData();
        }
    }
}
