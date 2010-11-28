using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nil
{
	public class String
	{
		public static string[] Tokenise(string input, string delimiter)
		{
			List<string> output = new List<string>();
			int lastOffset = 0;
			for (int i = 0; i < input.Length; )
			{
				int offset = input.IndexOf(delimiter, i);
				if (offset == -1)
					break;
				string token = input.Substring(i, offset - i);
				output.Add(token);
				i += delimiter.Length;
				lastOffset = i;
			}
			string lastToken = input.Substring(lastOffset);
			output.Add(lastToken);
			return output.ToArray();
		}
	}
}
