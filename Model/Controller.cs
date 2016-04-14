using System;
using System.Collections.Generic;
using CollectionTester.Interfaces;
using CollectionTester.Collections;
using Generate;
namespace CollectionTester.Model
{
    public class MyController : IController
    {
        public void TestAllCollectionsAndDisplayResults(int count_strings_add, int count_strings_delete, int count_strings_search, int size_string)
        {

            List<ICollectionWrapper> list = new List<ICollectionWrapper>();
            list.Add(new ListWrapper());
            list.Add(new StringWrapper());
            list.Add(new ArrayListWrapper());
            list.Add(new HashtableWrapper());
            list.Add(new HashtableGetHashCodeWrapper());
            list.Add(new HashSetWrapper());
            list.Add(new DictionaryWrapper());
            list.Add(new DictionaryGetHashCodeWrapper());
            list.Add(new SortedListWrapper());
            list.Add(new miyu8_TestCollection());
            long tick, addTime = 0, deleteTime = 0, searchTime = 0;
            GenerateRandom generaterandom = new GenerateRandom();
            string randomstring;
            List<TestingResult> listTime = new List<TestingResult>();
            foreach (ICollectionWrapper rec in list)
            {
                for (int i = 0; i < count_strings_add; i++)
                {
                    randomstring = generaterandom.RandomString(size_string);
                    tick = DateTime.Now.Ticks;
                    rec.Add(randomstring);
                    addTime += DateTime.Now.Ticks - tick;

                }
                for (int i = 0; i < count_strings_search; i++)
                {
                    randomstring = generaterandom.RandomString(size_string);
                    tick = DateTime.Now.Ticks;
                    rec.Contains(randomstring);
                    searchTime += DateTime.Now.Ticks - tick;
                }

                for (int i = 0; i < count_strings_delete; i++)
                {
                    randomstring = generaterandom.RandomString(size_string);
                    tick = DateTime.Now.Ticks;
                    rec.DeleteOneWord();
                    deleteTime += DateTime.Now.Ticks - tick;
                }
                listTime.Add(new TestingResult(new TimeSpan(addTime), new TimeSpan(deleteTime), new TimeSpan(searchTime), rec.CollectionType, rec.SystemTypeName));
            }
            listTime.Sort((a, b) => a.SearchTime.CompareTo(b.SearchTime));
            Console.WriteLine("Время добавления\tВремя удаления  \tВремя поиска    \tТип коллекции ");
            foreach (TestingResult rec in listTime)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", rec.AddTime, rec.DeleteTime, rec.SearchTime, rec.CollectionType);
            }
        }
    }
}
