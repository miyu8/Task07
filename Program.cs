using System;
using CollectionTester.Model;

namespace CollectionTester
{
    class Program
    {
        static void Main(string[] args)
        {
            MyController mycontroller = new MyController();
            mycontroller.TestAllCollectionsAndDisplayResults(10000, 10000, 10000, 10);
            Console.ReadKey();
        }
    }
}