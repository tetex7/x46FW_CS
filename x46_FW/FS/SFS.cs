using System;
using System.Collections.Generic;
using System.Text;

namespace x46_FW.FS
{
	public class SFS
	{
		static public void MKD(string pathString)
		{
			System.IO.Directory.CreateDirectory(pathString);

			if (!System.IO.File.Exists(pathString))
			{
				return;
			}
			else
			{
				throw new System.IO.DirectoryNotFoundException(pathString);
			}
		}

	}
}
