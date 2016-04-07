using System;
using System.Collections.Generic;
using CollectionTester.Interfaces;
using CollectionTester.Collections;
using Generate;

namespace CollectionTester.Model
{
    public class MyController : IController
    {
        public void TestAllCollectionsAndDisplayResults(int count_strings, int size_string)
        {
            List<ICollectionWrapper> list = new List<ICollectionWrapper>();
            list.Add(new ListWrapper());
            list.Add(new StringWrapper());
            list.Add(new ArrayListWrapper());
            list.Add(new HashtableWrapper());
            list.Add(new HashtableGetHashCodeWrapper((ListWrapper)list[0]));
            list.Add(new HashSetWrapper());
            list.Add(new DictionaryWrapper());
            list.Add(new DictionaryGetHashCodeWrapper((ListWrapper)list[0]));
            list.Add(new SortedListWrapper());
            list.Add(new miyu8_TestCollection());
            long ticks;
            GenerateRandom generaterandom;
            bool bool_contains;
            foreach (ICollectionWrapper rec in list)
            {
                ticks = DateTime.Now.Ticks;
                Console.WriteLine("Type {0}", rec.CollectionType);
                rec.Add(count_strings, size_string);
                Console.WriteLine("Add {0}", (double)(DateTime.Now.Ticks - ticks) / 1000000);
                generaterandom = new GenerateRandom();
                ticks = DateTime.Now.Ticks;
                bool_contains = rec.Contains(generaterandom.RandomString(size_string));
                Console.WriteLine("Contains {0}\t{1}", (double)(DateTime.Now.Ticks - ticks) / 1000000, bool_contains);
                ticks = DateTime.Now.Ticks;
                rec.Delete(count_strings);
                Console.WriteLine("Delete {0}", (double)(DateTime.Now.Ticks - ticks) / 1000000);
                Console.WriteLine(rec.Count);
            }
        }
    }
}
