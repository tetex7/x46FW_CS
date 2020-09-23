using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace x46_IO
{
	namespace GS
	{
		public class GS
		{
			public static Stream gsI;
			public static void GSISet(byte[] FT, int off, int cnt)
			{
				for (int o = 0; o < cnt; o++)
				{
					var fff = gsI.Read(FT, off, cnt);
				}
			}
		}
	}
}
