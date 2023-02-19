using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var NewBird = new Bird();
            NewBird.Fly = true;
            NewBird.Sing = true;
            NewBird.beaks = 3.4d;
            NewBird.Wings = 2;

            var NewReptile = new Reptile();
            NewReptile.ColdBlooded = true;
            NewReptile.LaysEggs = true;
            NewReptile.Habitat = "Desert";
            NewReptile.Age = 20;

            var NewAnimal = new Animal[] { NewBird, NewReptile };
            foreach (var animal in NewAnimal)
            {
                Console.WriteLine($" Birds and Reptiles: ");
                Console.WriteLine($" Legs: {animal.Legs} ");
                Console.WriteLine($"Eats {animal.Eats}");
                Console.WriteLine($"Breath: {animal.Breaths}");
                Console.WriteLine($"Age: {animal.Age}");
            }

            Console.WriteLine($"Birds have {NewBird.Wings} wings. Their beaks are {NewBird.beaks} long. Do they Sing? {NewBird.Sing} ");
            Console.WriteLine($"Reptile's habitat is {NewReptile.Habitat}. They mostly live {NewReptile.Age} years. Are they Cold Blooded? {NewReptile.ColdBlooded}");



            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
