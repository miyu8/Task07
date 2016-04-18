using System.Collections.Generic;
using System.Linq;
using CollectionTester.Interfaces;
using CollectionTester.Model;

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

        public void Add(string word)
        {
            internalList.Add(word, true);
        }

        public bool Contains(string word)
        {
            bool logic;
            return internalList.TryGetValue(word, out logic);
        }

        public void DeleteOneWord()
        {
            internalList.Remove(internalList.Keys.First());
        }
    }
}

