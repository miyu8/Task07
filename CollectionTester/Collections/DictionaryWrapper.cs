using System.Collections.Generic;
using System.Linq;
using CollectionTester.Interfaces;
using CollectionTester.Model;
using Generate;

namespace CollectionTester.Collections
{
    class DictionaryWrapper : ICollectionWrapper
    {
        protected Dictionary<string, bool> internalList = new Dictionary<string, bool>();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.Dictionary;
            }
        }

        public int Count
        {
            get
            {
                return internalList.Count;
            }
        }

        public string SystemTypeName
        {
            get
            {
                return internalList.GetType().FullName;
            }
        }

        public void Add(int count_strings, int size_string)
        {
            GenerateRandom generaterandom = new GenerateRandom();
            for (int i = 0; i < count_strings; i++)
            {
                internalList.Add(generaterandom.RandomString(size_string), true);
            }
        }

        public bool Contains(string word)
        {
            bool logic;
            return internalList.TryGetValue(word, out logic);
        }

        public void Delete(int count_strings)
        {
            if (count_strings > internalList.Count)
                count_strings = internalList.Count;
            for (int i = 0; i < count_strings; i++)
            {
                internalList.Remove(internalList.FirstOrDefault().Key);
            }
        }
    }
}

