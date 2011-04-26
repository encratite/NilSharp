using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
