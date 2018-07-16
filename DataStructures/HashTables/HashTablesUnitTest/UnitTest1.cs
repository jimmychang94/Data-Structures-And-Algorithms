using HashTables.Classes;
using System;
using Xunit;

namespace HashTablesUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddKeyValuePairToHashTableTest()
        {
            // Arrange
            string key = "Cat";
            int value = 10;

            HashTable hashTable = new HashTable();
            int index = hashTable.GetHash(key);

            // Act
            hashTable.Add(key, value);

            // Assert
            Assert.Equal("Cat", hashTable.Table[index].Key);
            Assert.Equal(10, hashTable.Table[index].Value);
        }

        [Fact]
        public void CanDetermineWhetherAKeyIsContainedInHashTableTest()
        {
            // Arrange
            string key = "Cat";
            int value = 10;

            HashTable hashTable = new HashTable();
            hashTable.Add(key, value);

            // Act
            bool testContains = hashTable.Contains(key);

            // Assert
            Assert.True(testContains);
        }

        [Fact]
        public void CanFindTheValueAssociatedWithAKeyInTheHashTableTest()
        {
            // Arrange
            string key = "Cat";
            int value = 10;

            HashTable hashTable = new HashTable();
            hashTable.Add(key, value);

            // Act
            int find = hashTable.Find(key);

            // Assert
            Assert.Equal(10, find);
        }

        [Fact]
        public void CanStoreCollisionOldKeyValuePairInTableTest()
        {
            // Arrange
            string key = "Cat";
            int value = 10;
            string keyCollision = "Doe";
            int valueCollision = 15;

            HashTable hashTable = new HashTable();
            hashTable.Add(key, value);
            hashTable.Add(keyCollision, valueCollision);

            // Act
            bool keyContain = hashTable.Contains(key);
            int find = hashTable.Find(key);

            // Assert
            Assert.True(keyContain);
            Assert.Equal(10, find);
        }

        [Fact]
        public void CanStoreCollisionNewKeyValuePairInHashTableTest()
        {
            // Arrange
            string key = "Cat";
            int value = 10;
            string keyCollision = "Doe";
            int valueCollision = 15;

            HashTable hashTable = new HashTable();
            hashTable.Add(key, value);
            hashTable.Add(keyCollision, valueCollision);

            // Act
            bool collisionContain = hashTable.Contains(keyCollision);
            int findCollision = hashTable.Find(keyCollision);

            // Assert
            Assert.True(collisionContain);
            Assert.Equal(15, findCollision);
        }
    }
}
