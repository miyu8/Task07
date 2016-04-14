using System;
using System.Linq;
using CollectionTester.Interfaces;
using CollectionTester.Model;

namespace CollectionTester.Collections
{
    class StringWrapper : ICollectionWrapper
    {
        protected string[] internalList = null;
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.String;
            }
        }

        public int Count
        {
            get
            {
                return internalList.Length;
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
            int j = 0;
            if (internalList != null)
                j = internalList.Length;
            Array.Resize<string>(ref internalList, j + 1);
            internalList[internalList.Length - 1] = word;
        }

        public bool Contains(string word)
        {
            return internalList.Contains(word);
        }

        public void DeleteOneWord()
        {
            Array.Resize<string>(ref internalList, internalList.Length - 1);
        }
    }
}
