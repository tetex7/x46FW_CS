using System;
using x46_FW.quadFX.MM;
using x46_FW.quadFX;
//using x46FW_API;
using System.Runtime.InteropServices.ComTypes;

namespace x46_tester_CLT
{
	class Program
	{
		static x46_FW.MISex MI = new x46_FW.MISex("dd", 111);
		static void Main(/*string[] args*/)
		{
			var ff = TISM.PUS("TYPEATTR", ConsoleKey.F1);
			Console.WriteLine("Hello World!");
			//throw new x46_FW.MIS.MIS_EXS.ModuleNotFoundException(MI.m_name);
			Console.WriteLine(MI.m_sID);
			System.Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
		}
	}
}
