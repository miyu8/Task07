using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester.Model
{
	public class TestOptions
	{
		public int MaxWordCount { get; private set; }
		public int CharsInWord { get; private set; }
		public string Alphabet { get; private set; }

		public TestOptions(int maxWordCount, int charsInWord, string alphabet)
		{
			MaxWordCount = maxWordCount;
			CharsInWord = charsInWord;
			Alphabet = alphabet;
		}
	}
}
