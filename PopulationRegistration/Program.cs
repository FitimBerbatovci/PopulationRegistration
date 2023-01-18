using System;
using System.Collections.Generic;

namespace PopulationRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store the population records
            List<Person> population = new List<Person>();

            // Loop until the user wants to exit
            while (true)
            {
                // Display the menu
                Console.WriteLine("1. Shto nje Person");
                Console.WriteLine("2. Shiko Popollsine");
                Console.WriteLine("3. Mbylle");
                Console.WriteLine("Shtypeni Zgjidhjen tuaj:");
                int choice = int.Parse(Console.ReadLine());

                // Perform the selected action
                switch (choice)
                {
                    case 1:
                        // Add a new person
                        Console.WriteLine("Shtypeni emrin e Personit:");
                        string emri = Console.ReadLine();
                        Console.WriteLine("Shtypeni moshen e Personit:");
                        int mosha = int.Parse(Console.ReadLine());
                        Console.WriteLine("Shtypeni gjinin e Personit (M/F):");
                        char gjinia = char.Parse(Console.ReadLine());
                        population.Add(new Person(emri, mosha, gjinia));
                        break;
                    case 2:
                        // View the population
                        Console.WriteLine("Popoullsia:");
                        foreach (Person p in population)
                        {
                            Console.WriteLine($"Emri: {p.Emri}, Mosha: {p.Mosha}, Gjinia: {p.Gjinia}");
                        }
                        break;
                    case 3:
                        // Exit the program
                        return;
                    default:
                        Console.WriteLine("Zgjedhje e Gabuar. Provoni Perseri!!.");
                        break;
                }
            }
        }
    }

    // Person class to represent a person in the population
    class Person
    {
        private int mosha;

        public string? Emri { get; }

        private char gjina;

        public Person(string? emri, int mosha, char gjinia)
        {
            Emri = emri;
            Mosha = mosha;
            Gjinia = gjinia; 
        }

        public string Name
        {
            get;
        }
        public object Mosha { get; internal set; }
        public object Gjina { get; internal set; }
        public object Gjinia { get; internal set; }
    }
}
