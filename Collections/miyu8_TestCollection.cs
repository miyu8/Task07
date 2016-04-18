using System;
using CollectionTester.Interfaces;
using CollectionTester.Model;

namespace CollectionTester.Collections
{
    class miyu8_TestCollection : ICollectionWrapper
    {
        protected string[] internalList = null;
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.miyu8_TestCollection;
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
            Array.Sort(internalList);
        }

        public bool Contains(string word)
        {
            for (int i = 0; i < internalList.Length; i++)
            {
                if (internalList[i].CompareTo(word) >= 0)
                    if (internalList[i].CompareTo(word) == 0)
                        return true;
                    else
                        return false;
            }
            return false;
        }

        public void DeleteOneWord()
        {
            Array.Resize<string>(ref internalList, internalList.Length - 1);
        }
    }
}

