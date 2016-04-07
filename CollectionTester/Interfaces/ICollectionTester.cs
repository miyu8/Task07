using CollectionTester.Model;

namespace CollectionTester.Interfaces
{
    public interface ICollectionTester
    {
        TestingResult TestCollection(ICollectionWrapper collection);
    }
}
