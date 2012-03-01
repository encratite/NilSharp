using System;

namespace Nil
{
	public class Time
	{
		public static string Timestamp()
		{
			return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		}
	}
}
