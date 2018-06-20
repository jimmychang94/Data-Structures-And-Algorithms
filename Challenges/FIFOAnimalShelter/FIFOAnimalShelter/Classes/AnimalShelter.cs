using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    /// <summary>
    /// The animal shelter class is like the queue class but has additional responsiblitity with the values of each "node" (animal)
    /// </summary>
    public class AnimalShelter
    {
        /// <summary>
        ///  This is the same as the rear in a queue, it holds the most recent addition to the queue.
        /// </summary>
        public Animal Rear { get; set; }

        /// <summary>
        ///  This is the same as a front in a queue, it holds the oldest addition to the queue.
        /// </summary>
        public Animal Front { get; set; }

        /// <summary>
        /// This constructor function makes sure that the Animal Shelter has at least 1 animal in it.
        /// </summary>
        /// <param name="animal">The starting animal in the animal shelter</param>
        public AnimalShelter(Animal animal)
        {
            Rear = animal;
            Front = animal;
        }

        /// <summary>
        /// This method enqueues the animal to the animal shelter queue.
        /// This means that it attempts to add an animal to the animal shelter.
        /// It only adds an animal to the shelter if it is a cat or a dog.
        /// </summary>
        /// <param name="animal">The animal attempted to be added to the shelter</param>
        public void Enqueue(Animal animal)
        {
            if ((animal.Value == "dog") || (animal.Value == "cat"))
            {
                Rear.Next = animal;
                Rear = Rear.Next;
            }
        }

        /// <summary>
        /// This method dequeues an animal from the shelter, giving preference to the animal type given.
        /// This means that it tries to find the animal type that is received
        /// If it does, it returns the animal of that type that has been in the shelter the longest.
        /// If it doesn't, it returns the animal that has been in the shelter the longest.
        /// </summary>
        /// <param name="pref">This is the type of animal that you want to remove from the shelter</param>
        /// <returns>If there, the animal of that type that has been in the shelter the longest,
        /// otherwise the animal that has been in the shelter the longest</returns>
        public Animal Dequeue(string pref)
        {
            Animal prefAnimal = Front;
            Animal temp = Front;
            if (prefAnimal.Value == pref)
            {
                Front = Front.Next;
                prefAnimal.Next = null;
                return prefAnimal;
            }
            while (Front.Value != pref)
            {
                Enqueue(Dequeue());
                if ((Front == temp) && (Front.Value != pref))
                {
                    prefAnimal = Dequeue();
                    return prefAnimal;
                }
            }
            prefAnimal = Dequeue();
            while (Front != temp)
            {
                Enqueue(Dequeue());
            }
            return prefAnimal;
        }

        /// <summary>
        /// The normal dequeue method that returns the front animal in the animal shelter.
        /// </summary>
        /// <returns>The front animal in the animal shelter</returns>
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;

            return temp;
        }

        /// <summary>
        /// This method is to see the order of the queue. The arrows point towards the newer animals.
        /// The newest animal points to NULL.
        /// </summary>
        public void Print()
        {
            Animal current = Front;
            while (current.Next != null)
            {
                Console.Write($"{current.Value}-->");
                current = current.Next;
            }
            Console.Write($"{current.Value}-->");
            Console.Write("NULL");
            Console.WriteLine();
        }
    }
}
