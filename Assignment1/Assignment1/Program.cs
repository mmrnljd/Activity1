﻿using System;
using System.Collections.Generic;

namespace PersonWeightTracker
{
    class Person
    {
        public string Name { get; set; }
        public int Weight { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Console.WriteLine("Welcome to the Person Weight Tracker!");

            while (true)
            {
                Console.WriteLine("Enter the person's name (or type 'done' to finish):");
                string name = Console.ReadLine();

                if (name.ToLower() == "done")
                    break;

                Console.WriteLine("Enter the person's weight:");
                int weight;
                if (!int.TryParse(Console.ReadLine(), out weight))
                {
                    Console.WriteLine("Invalid weight. Please enter a valid integer.");
                    continue;
                }

                Person person = new Person
                {
                    Name = name,
                    Weight = weight
                };

                people.Add(person);
            }

            int totalWeight = 0;
            Console.WriteLine("\nPeople and their weights:");
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name}: {person.Weight}kg");
                totalWeight += person.Weight;
            }

            Console.WriteLine($"\nTotal weight of all people: {totalWeight}kg");
            Console.WriteLine("\nThank you for using the Person Weight Tracker!");
        }
    }
}