﻿using CollectionTester.Interfaces;
using CollectionTester.Model;
using Generate;
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

        public void Add(int count_strings, int size_string)
        {
            GenerateRandom generaterandom = new GenerateRandom();
            for (int i = 0; i < count_strings; i++)
            {
                internalList.Add(generaterandom.RandomString(size_string));
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
            for (int i = 0; i < count_strings; i++)
                internalList.RemoveAt(0);
        }
    }
}
