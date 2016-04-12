using System;
using CollectionTester.Interfaces;
using CollectionTester.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestFactory()
        {
            ICollectionFactory factory = GetCollectionFactory();
            foreach (CollectionType tp in Enum.GetValues(typeof(CollectionType)))
            {
                ICollectionWrapper collection = factory.CreateCollection(tp);
                Assert.IsNotNull(collection);
                Assert.AreEqual(tp, collection.CollectionType);
            }
        }
        [TestMethod]
        public void TestCollectionTester()
        {
            ICollectionFactory factory = GetCollectionFactory();
            ICollectionTester tester = GetCollectionTester();
            foreach (CollectionType tp in Enum.GetValues(typeof(CollectionType)))
            {
                ICollectionWrapper collection = factory.CreateCollection(tp);
                TestingResult result = tester.TestCollection(collection);
                Assert.IsNotNull(result);
                Assert.AreEqual(tp, result.CollectionType);
                Assert.IsTrue(result.AddTime.Ticks > 0);
                Assert.IsTrue(result.DeleteTime.Ticks > 0);
                Assert.IsTrue(result.SearchTime.Ticks > 0);
            }
        }
        [TestMethod]
        public void TestCollectionWrapper()
        {
            throw new NotImplementedException();
        }

        #region Private Methods
        private ICollectionFactory GetCollectionFactory()
        {
            throw new NotImplementedException();
        }
        private ICollectionTester GetCollectionTester()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
