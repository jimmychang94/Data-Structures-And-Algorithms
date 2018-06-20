using System;
using Xunit;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelterUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueWorksForDogTest()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter(new Animal("cat"));

            // Act
            animalShelter.Enqueue(new Animal("dog"));

            // Assert
            Assert.Equal("dog", animalShelter.Rear.Value);
        }

        [Fact]
        public void EnqueueWorksForCatTest()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter(new Animal("dog"));

            // Act
            animalShelter.Enqueue(new Animal("cat"));

            // Assert
            Assert.Equal("cat", animalShelter.Rear.Value);
        }

        [Fact]
        public void EnqueueDoesNotWorkForNotCatOrDogTest()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter(new Animal("cat"));

            // Act
            animalShelter.Enqueue(new Animal("rabbit"));

            // Assert
            Assert.NotEqual("rabbit", animalShelter.Rear.Value);
        }

        [Fact]
        public void DequeueInputIsEqualToFrontValueTest()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter(new Animal("dog"));
            animalShelter.Enqueue(new Animal("dog"));
            animalShelter.Enqueue(new Animal("cat"));

            // Act
            Animal adopted = animalShelter.Dequeue("dog");

            // Assert
            Assert.Equal("dog", adopted.Value);
        }

        [Fact]
        public void DequeueInputIsNotEqualToFrontValueTest()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter(new Animal("dog"));
            animalShelter.Enqueue(new Animal("dog"));
            animalShelter.Enqueue(new Animal("cat"));

            // Act
            Animal adopted = animalShelter.Dequeue("cat");

            // Assert
            Assert.Equal("cat", adopted.Value);
            Assert.Equal("dog", animalShelter.Front.Value);
        }

        [Fact]
        public void DequeueInputIsNotCatOrDogTest()
        {
            // Arrange
            AnimalShelter animalShelter = new AnimalShelter(new Animal("dog"));
            animalShelter.Enqueue(new Animal("dog"));
            animalShelter.Enqueue(new Animal("cat"));

            // Act
            Animal adopted = animalShelter.Dequeue("horse");

            // Assert
            Assert.Equal("dog", adopted.Value);
        }
    }
}
