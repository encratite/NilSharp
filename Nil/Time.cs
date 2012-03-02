using System;

namespace Nil
{
	public static class Time
	{
		public static string Timestamp()
		{
			return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		}
	}
}
