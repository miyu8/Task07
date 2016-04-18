using CollectionTester.Interfaces;
using CollectionTester.Model;
using System.Linq;
using System.Collections.Generic;

namespace CollectionTester.Collections
{
    class HashSetWrapper : ICollectionWrapper
    {
        protected HashSet<string> internalList = new HashSet<string>();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.HashSet;
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
            internalList.Add(word);
        }

        public bool Contains(string word)
        {
            return internalList.Contains(word);
        }

        public void DeleteOneWord()
        {
            internalList.Remove(internalList.First());
        }
    }
}
