using System;
using System.IO;

namespace Nil
{
	public static class File
	{
		public enum FileType
		{
			File,
			Directory,
			DoesNotExist,
		}

		public static FileType GetFileType(string path)
		{
			try
			{
				FileAttributes attributes = System.IO.File.GetAttributes(path);
				return
					(attributes & FileAttributes.Directory) != 0 ?
					FileType.Directory :
					FileType.File;
			}
			catch (Exception)
			{
				return FileType.DoesNotExist;
			}
		}
	}
}
