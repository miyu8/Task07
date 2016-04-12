using CollectionTester.Model;

namespace CollectionTester.Interfaces
{
    public interface ICollectionWrapper
    {
        CollectionType CollectionType { get; }
        string SystemTypeName { get; }
        int Count { get; }

        void Add(int count_strings, int size_string);
        void Delete(int count_strings);
        bool Contains(string word);
    }
}
