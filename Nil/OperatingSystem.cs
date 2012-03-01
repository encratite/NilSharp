using System;

namespace Nil
{
	public class OperatingSystem
	{
		public static string Name()
		{
			System.OperatingSystem operatingSystem = Environment.OSVersion;
			string osName = "Unknown operating system";

			switch (operatingSystem.Platform)
			{
				case System.PlatformID.Win32Windows:
					switch (operatingSystem.Version.Minor)
					{
						case 0:
							osName = "Windows 95";
							break;
						case 10:
							osName = "Windows 98";
							break;
						case 90:
							osName = "Windows ME";
							break;
						default:
							osName = "Unknown 9x family Windows";
							break;
					}
					break;
				case System.PlatformID.Win32NT:
					switch (operatingSystem.Version.Major)
					{
						case 3:
							osName = "Windws NT 3.51";
							break;
						case 4:
							osName = "Windows NT 4";
							break;
						case 5:
							if (operatingSystem.Version.Minor == 0)
								osName = "Windows 2000";
							else if (operatingSystem.Version.Minor == 1)
								osName = "Windows XP";
							else if (operatingSystem.Version.Minor == 2)
								osName = "Windows Server 2003";
							break;
						case 6:
							osName = "Windows Vista";
							if (operatingSystem.Version.Minor == 0)
								osName = "Windows Vista";
							else if (operatingSystem.Version.Minor == 1)
								osName = "Windows 7";
							else
								osName = "Unknown NT 6.x family Windows";
							break;
						default:
							osName = "Unknown NT family Windows";
							break;
					}
					break;
			}

			return osName;
		}
	}
}
