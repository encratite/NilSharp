using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nil
{
	public class File
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
			catch (FileNotFoundException)
			{
				return FileType.DoesNotExist;
			}
			catch (DirectoryNotFoundException)
			{
				return FileType.DoesNotExist;
			}
		}
	}
}
