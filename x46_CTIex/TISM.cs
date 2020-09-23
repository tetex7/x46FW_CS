using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Xml;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using x46_varEx.LM;
using x46_PWex;
using x46_IO;
using x46_IO.GS;
using x46_CTIex.quadFX;

namespace x46_CTIex
{
	public class TISM
	{
		public static string[] ONS;
		public static Task textDS(string INS)
		{
			Console.WriteLine(INS);
			return Task.CompletedTask;
		}

		public static string PUS(string UP, ConsoleKey KEY)
		{
			Console.Write(UP);
			while (Console.ReadKey().Key != KEY)
			{
				Console.ReadKey(false);
			}
			return FXS.oFXSsg();
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
				FXS.STS(FXS.oFXSg(), GS.gsI);
            }
			return FXS.oFXSsg();
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
			return FXS.oFXSsg();
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
}
