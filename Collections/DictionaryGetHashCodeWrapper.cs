using CollectionTester.Interfaces;
using CollectionTester.Model;
using System.Collections.Generic;
using System.Linq;
namespace CollectionTester.Collections
{
    class DictionaryGetHashCodeWrapper : ICollectionWrapper
    {
        protected Dictionary<int, string> internalList = new Dictionary<int, string>();

        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.DictionaryGetHashCode;
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
            try
            {
                internalList.Add(word.GetHashCode(), word);
            }
            catch
            {

            }
        }

        public bool Contains(string word)
        {
            return internalList.ContainsKey(word.GetHashCode());
        }

        public void DeleteOneWord()
        {
            internalList.Remove(internalList.Keys.First());
        }
    }
}
