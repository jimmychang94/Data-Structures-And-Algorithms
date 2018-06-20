using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    /// <summary>
    /// This Animal class is basically the Node class but with string instead of int.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// This holds what kind of animal it is; whether it be cat, dog, or something else
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// This holds a reference to another animal, like a Node.
        /// </summary>
        public Animal Next { get; set; }

        /// <summary>
        /// This constructor makes sure that each animal has a type associated with it.
        /// </summary>
        /// <param name="value">The kind of animal it is</param>
        public Animal(string value)
        {
            Value = value;
        }
    }
}
