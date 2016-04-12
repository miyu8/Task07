namespace CollectionTester.Interfaces
{
    public interface ICollectionFactory
    {
        ICollectionWrapper CreateCollection(Model.CollectionType collectionType);
    }
}
