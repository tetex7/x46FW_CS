using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace x46_CTIex
{
	namespace quadFX
	{
		public class MFX
		{
			public static void BCC(ConsoleColor color)
            {
				Console.BackgroundColor = color;
            }

			public static void CTT(string name)
			{
				Console.Title = name;
			}
		}

		namespace MM
		{
			public class MMFX
            {
				public static Task MMT()
                {
                    MFX.CTT("MMFX");
					MFX.BCC(ConsoleColor.Cyan);
					return Task.CompletedTask;
                }
            }
		}
	}
}
