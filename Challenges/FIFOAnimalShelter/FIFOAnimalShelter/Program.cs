using System;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            FIFOAnimalShelter();
        }

        /// <summary>
        /// This is a basic test to make sure that everything works
        /// </summary>
        static void FIFOAnimalShelter()
        {

            AnimalShelter animalShelter = new AnimalShelter(new Animal("cat"));
            animalShelter.Enqueue(new Animal("dog"));
            animalShelter.Enqueue(new Animal("cat"));
            animalShelter.Enqueue(new Animal("dog"));
            animalShelter.Enqueue(new Animal("dog"));
            animalShelter.Enqueue(new Animal("cat"));
            animalShelter.Enqueue(new Animal("dog"));
            animalShelter.Enqueue(new Animal("dog"));
            animalShelter.Enqueue(new Animal("dog"));
            animalShelter.Enqueue(new Animal("cat"));
            animalShelter.Enqueue(new Animal("cat"));
            animalShelter.Print();
            string pref = "dog";
            Animal dequeuedAnimal = animalShelter.Dequeue(pref);
            animalShelter.Print();
            Console.WriteLine(dequeuedAnimal.Value);

        }
    }
}
