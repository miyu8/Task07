using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionTester.Model;

namespace CollectionTester.Interfaces
{
	public interface ICollectionTester
	{
        TestingResult TestCollection(ICollectionWrapper collection);
	}
}
