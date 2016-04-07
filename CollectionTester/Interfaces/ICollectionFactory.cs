﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester.Interfaces
{
	public interface ICollectionFactory
	{
		ICollectionWrapper CreateCollection(Model.CollectionType collectionType);
	}
}
