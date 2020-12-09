using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using x46_FW.MIS;
using x46_FW;


namespace x46_FW
{
	namespace newIO
	{
		public class x46_IO : IFSlib.iMIS
		{
			public static MISex x46_IO_MID = new MISex("x46FW.IO", 0x011454FF, true, "R0.1");
        }

		public class FXS
		{
		

			public static void RSFXs(byte[] FT, int off, int cnt)
			{
				for (int o = 0; o < cnt; o++)
				{
					var fff = Console.OpenStandardOutput().Read(FT, off, cnt);
				}
			}

			public static void STS(Stream from, Stream to)
			{
				from.CopyTo(to);
			}

			public static string oFXSsg()
			{
				return Console.OpenStandardOutput().ToString();
			}

			public static Stream oFXSg()
			{
				return Console.OpenStandardOutput();
			}

			public static string iFXSsg()
			{
				return Console.OpenStandardInput().ToString();
			}
		}

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
}

	
