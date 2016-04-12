using System;
using CollectionTester.Model;

namespace CollectionTester
{
    class Program
    {
        static void Main(string[] args)
        {
            MyController mycontroller = new MyController();
            mycontroller.TestAllCollectionsAndDisplayResults(2000, 10);
            Console.ReadKey();
        }
    }
}
