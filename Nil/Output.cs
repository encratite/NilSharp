using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nil
{
	public class Output
	{
		static Object consoleLock = new Object();

		public static void Write(string input)
		{
			lock (consoleLock)
			{
				Console.Write(input);
			}
		}

		public static void WriteLine(string input)
		{
			Write(input + "\n");
		}
	}
}
