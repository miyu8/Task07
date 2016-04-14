using System;

namespace CollectionTester.Model
{
    public class TestingResult
    {
        public TimeSpan AddTime { get; private set; }
        public TimeSpan DeleteTime { get; private set; }
        public TimeSpan SearchTime { get; private set; }
        public CollectionType CollectionType { get; private set; }
        public string SystemTypeName { get; private set; }
        public TestingResult(TimeSpan addTime, TimeSpan deleteTime, TimeSpan searchTime, CollectionType collectionType, string systemTypeName)
        {
            AddTime = addTime;
            DeleteTime = deleteTime;
            SearchTime = searchTime;
            CollectionType = collectionType;
        }
    }
}
