using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProgram
{
    internal class MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);  // |-5| =5 |3|=3 |-3|=3
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        // 5-4345 7-8765456 8-8745
        protected int GetArrayPosition(K key)// 5->-7654323456     5->  7654323456 //78-87654568745 
        { // 100 ->876543456787654  -> 100->876543456787654
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        public struct KeyValue<k, v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
        }
        public void FindFrequency(string[] words) // this method is used to find the count of each word
        {
            Dictionary<string, int> WordFrequency = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (WordFrequency.ContainsKey(word)) // this condition is to check whether the dictionary already contains the word or not
                {// if condition becomes true it means that word is already present and then the value is increment by 1
                    WordFrequency[word] += 1;
                }
                else // if condition becomes false it means that the word is occured one time only
                {
                    WordFrequency.Add(word, 1);
                }
            }
            Console.WriteLine("\nThe Frequency of Words are: \nCount    Word");
            foreach (var word in WordFrequency) // foreach loop is used to print the dictionary
            {
                Console.WriteLine(word.Value + "\t" + word.Key);
            }
        }
    }
}