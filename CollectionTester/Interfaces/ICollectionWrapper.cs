using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
