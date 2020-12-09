using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace x46_FW.CPUs
{
	public class CPUbit
	{
		public static bool gCPUbits()
		{
			var BIT = System.Environment.Is64BitProcess;
			return BIT;
		}
	}
}
