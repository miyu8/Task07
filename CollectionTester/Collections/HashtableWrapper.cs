using CollectionTester.Interfaces;
using CollectionTester.Model;
using Generate;
using System.Collections;

namespace CollectionTester.Collections
{
    class HashtableWrapper : ICollectionWrapper
    {
        protected Hashtable internalList = new Hashtable();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.Hashtable;
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
                try
                {
                    internalList.Add(generaterandom.RandomString(size_string), true);
                }
                catch
                {
                    internalList.Add(i, i);
                }
            }
        }

        public bool Contains(string word)
        {
            return internalList.Contains(word);
        }

        public void Delete(int count_strings)
        {
            if (count_strings > internalList.Count)
                count_strings = internalList.Count;
            IDictionaryEnumerator myEnumerator = internalList.GetEnumerator();
            myEnumerator.MoveNext();
            for (int i = 0; i < count_strings; i++)
            {
                internalList.Remove(myEnumerator.Key);
                myEnumerator = internalList.GetEnumerator();
                myEnumerator.MoveNext();
            }
        }
    }
}
