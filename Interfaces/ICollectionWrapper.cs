using CollectionTester.Model;

namespace CollectionTester.Interfaces
{
    public interface ICollectionWrapper
    {
        CollectionType CollectionType { get; }
        string SystemTypeName { get; }
        int Count { get; }
        void Add(string word);
        void DeleteOneWord();
        bool Contains(string word);
    }
}
