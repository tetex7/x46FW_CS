﻿using System;
using x46_FW.quadFX.MM;
using x46_FW.quadFX;
//using x46FW_API;
using System.Runtime.InteropServices.ComTypes;
using System.Linq.Expressions;

namespace x46_tester_CLT
{
	class Program
	{
		//static int f = 00;
		//static int* fff = f;
		static x46_FW.MISex MI = new x46_FW.MISex("dd", 111);
		static void Main(/*string[] args*/)
		{
			var ff = TISM.PUS("TYPEATTR", ConsoleKey.F1);
			Console.Beep();
			Console.WriteLine("");
			Console.WriteLine("Hello World!");
			//throw new x46_FW.MIS.MIS_EXS.ModuleNotFoundException(MI.m_name);
			Console.WriteLine(MI.m_ID);
			System.Console.WriteLine("Press any key to exit.");
			System.Console.ReadKey();
			throw new x46_FW.MIS.EXC.ModuleGenericException(x46_FW.IO.x46_IO.x46_IO_MID.m_name);
		}
	}
}
