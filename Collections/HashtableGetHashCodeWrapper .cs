using CollectionTester.Interfaces;
using CollectionTester.Model;
using System.Collections;
namespace CollectionTester.Collections
{
    class HashtableGetHashCodeWrapper : ICollectionWrapper
    {
        protected Hashtable internalList = new Hashtable();

        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.HashtableGetHashCode;
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
            return internalList.Contains(word.GetHashCode());
        }

        public void DeleteOneWord()
        {
            IDictionaryEnumerator myEnumerator = internalList.GetEnumerator();
            myEnumerator.MoveNext();
            internalList.Remove(myEnumerator.Key);
        }
    }
}
