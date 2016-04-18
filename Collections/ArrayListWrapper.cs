using CollectionTester.Interfaces;
using CollectionTester.Model;
using System.Collections;

namespace CollectionTester.Collections
{
    class ArrayListWrapper : ICollectionWrapper
    {
        protected ArrayList internalList = new ArrayList();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.ArrayList;
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
            internalList.RemoveAt(0);
        }
    }
}
