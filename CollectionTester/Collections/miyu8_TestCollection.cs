using System;
using System.Linq;
using CollectionTester.Interfaces;
using CollectionTester.Model;
using Generate;

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
                //internalList
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

        public void Add(int count_strings, int size_string)
        {
            int j = 0;
            if (internalList != null)
                j = internalList.Length;
            Array.Resize<string>(ref internalList, j + count_strings);
            GenerateRandom generaterandom = new GenerateRandom();
            for (int i = 0; i < count_strings; i++)
                internalList[i] = generaterandom.RandomString(size_string);
            Array.Sort(internalList);
        }

        public bool Contains(string word)
        {
            return internalList.Contains(word);
        }

        public void Delete(int count_strings)
        {
            if (count_strings > internalList.Length)
                count_strings = internalList.Length;
            Array.Resize<string>(ref internalList, internalList.Length - count_strings);
        }
    }
}

