using System;

namespace Nil
{
	public static class Time
	{
		public static string Timestamp()
		{
			return DateTime.Now.ToStandardString();
		}

		public static string ToStandardString(this DateTime time)
		{
			return time.ToString("yyyy-MM-dd HH:mm:ss");
		}
	}
}
