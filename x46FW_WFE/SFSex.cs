using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace x46FW_WFE
{
	namespace SFS
	{
		public class SFSex
		{
			public static void MMDR()
			{
				string root = @"C:\x46";
				// If directory does not exist, create it. 
				if (!Directory.Exists(root))
				{
					Directory.CreateDirectory(root);
				}
			}
        }
	}
}
