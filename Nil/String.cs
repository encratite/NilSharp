using System;
using System.Collections.Generic;

namespace Nil
{
	public static class String
	{
		public static string[] Tokenise(this string input, string delimiter)
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

		public static string GetFileSizeString(long size)
		{
			string[] units =
			{
				"B",
				"KiB",
				"MiB",
				"GiB",
				"TiB",
			};

			const int factor = 1024;
			double correctedSize = size;
			int unitIndex = 0;
			while (correctedSize >= factor && unitIndex < units.Length - 1)
			{
				correctedSize /= factor;
				unitIndex++;
			}
			string sizeString;
			if (unitIndex == 0)
				sizeString = size.ToString();
			else
				sizeString = string.Format("{0:F2}", correctedSize);
			sizeString += " " + units[unitIndex];
			return sizeString;
		}
	}
}
