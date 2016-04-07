using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionTester.Interfaces;
using CollectionTester.Model;

namespace CollectionTester.Collections
{
	class ListWrapper : ICollectionWrapper
	{
		private List<string> internalList = new List<string>();
		public CollectionType CollectionType
		{
			get
			{
				return CollectionType.List;
			}
		}

		public int Count
		{
			get
			{
				return internalList.Count;
            }
		}

		public string SystemTypeName
		{
			get
			{
				return internalList.GetType().FullName;
            }
		}

		public void Add(string word)
		{
			internalList.Add(word);
        }

		public bool Contains(string word)
		{
			return internalList.Contains(word);
        }

		public void DeleteOneWord()
		{
			internalList.RemoveAt(0);
        }
	}
}
