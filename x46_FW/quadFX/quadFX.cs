﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using x46_FW.IO;
using x46_FW.IOl.GS;

namespace x46_FW
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

		public class TISM
		{
			//public static string[] ONS;
			public static Task textDS(string INS)
			{
				Console.WriteLine(INS);
				return Task.CompletedTask;
			}

			public static string PUS(string UP, ConsoleKey KEY)
			{
				Console.WriteLine(UP);
				while (Console.ReadKey().Key != KEY)
				{
					Console.ReadKey(false);
				}
				return IOl.FXS.oFXSsg();
			}

			public static string PUS(string UP, ConsoleKey KEY, bool STGS)
			{
				Console.Write(UP);
				while (Console.ReadKey().Key != KEY)
				{
					Console.ReadKey(false);
				}

				if (STGS)
				{
					IOl.FXS.STS(IOl.FXS.oFXSg(), GS.gsI);
				}
				return IOl.FXS.oFXSsg();
			}

			public static string PUS(string UP, ConsoleKey KEY, string TIT)
			{
				MFX.CTT(TIT);
				Console.Write(UP);
				while (Console.ReadKey().Key != KEY)
				{
					Console.ReadKey(false);
				}
				MFX.CTT("/n");
				return IOl.FXS.oFXSsg();
			}

			public static Task textDS(string[] INS, bool NL)
			{
				foreach (var line in INS)
				{
					Console.WriteLine(INS);
				}
				return Task.CompletedTask;
			}
		}

		namespace MM
		{
			public class MMFX
			{
				public static Task MMT()
				{
					MFX.CTT("MMFX");
					//MFX.BCC(ConsoleColor.Cyan);
					return Task.CompletedTask;
				}
			}
		}
	}
}
