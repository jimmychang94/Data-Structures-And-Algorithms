using System;
using System.Collections.Generic;
using System.Text;

namespace LeftJoin.Classes
{
    public class HashTable
    {
        /// <summary>
        /// This array holds the key/value pairs
        /// </summary>
        public Node[] Table { get; set; } = new Node[1024];
        /// <summary>
        /// This is used for traversal when there are collisions
        /// </summary>
        public Node Current { get; set; }

        /// <summary>
        /// This takes in a key/value pair, hashes it, and adds it to the table.
        /// </summary>
        /// <param name="key">The key which will be hashed</param>
        /// <param name="value">The value corresponding to the key</param>
        public void Add(string key, string value)
        {
            if (Contains(key))
            {
                throw new Exception("Key already exists");
            }
            int hash = GetHash(key);
            Node node = new Node
            {
                Key = key,
                Value = value
            };
            if (Table[hash] == null)
            {
                Table[hash] = node;
                return;
            }
            Current = Table[hash];
            Table[hash] = node;
            Table[hash].Next = Current;
        }

        /// <summary>
        /// This takes a key and "hashes" it into an index within the hash table
        /// </summary>
        /// <param name="key">The key to be hashed</param>
        /// <returns>The index where the key/value pair will be stored</returns>
        public int GetHash(string key)
        {
            int hash = 0;
            foreach (char x in key)
            {
                hash += x;
            }
            hash *= 599;
            hash /= Table.Length;

            return hash;
        }

        /// <summary>
        /// This finds the value corresponding to the given key
        /// If there is no key stored in the table, it will return -1
        /// </summary>
        /// <param name="key">The key to find</param>
        /// <returns>The value corresponding to the key</returns>
        public string Find(string key)
        {
            int index = GetHash(key);
            Current = Table[index];
            while (Current.Next != null)
            {
                if (Current.Key == key)
                {
                    return Current.Value;
                }
                Current = Current.Next;
            }
            if (Current.Key == key)
            {
                return Current.Value;
            }
            return null;
        }

        /// <summary>
        /// This checks to see if a key is within the table.
        /// </summary>
        /// <param name="key">The key to find</param>
        /// <returns>true or false depending on whether the key exists in the table</returns>
        public bool Contains(string key)
        {
            int index = GetHash(key);
            Current = Table[index];
            if (Current == null)
            {
                return false;
            }
            while (Current.Next != null)
            {
                if (Current.Key == key)
                {
                    return true;
                }
                Current = Current.Next;
            }
            if (Current.Key == key)
            {
                return true;
            }
            return false;
        }
    }
}
