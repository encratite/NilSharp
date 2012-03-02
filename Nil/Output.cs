using System;

namespace Nil
{
	public static class Output
	{
		static Object consoleLock = new Object();

		public static void Write(string input, params object[] arguments)
		{
			lock (consoleLock)
			{
				Console.Write(input, arguments);
			}
		}

		public static void WriteLine(string input, params object[] arguments)
		{
			lock (consoleLock)
			{
				Console.WriteLine(input, arguments);
			}
		}
	}
}
