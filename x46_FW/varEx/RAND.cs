using System;
using System.Collections.Generic;
using System.Text;

namespace x46_FW.varEx
{

	[core.MISex("RAND", 0x1551)]
    public static class RAND
    {
		private static ulong ___IRANDHASG(long Sseed)
		{
			ulong rt = (ulong)Sseed.ToString().GetHashCode();
			return rt;
		}

		/// <summary>
		/// a random number generator
		/// </summary>
		/// <param name="seed"></param>
		/// <returns>a random number</returns>
		public static long iRand(long seed)
		{
			DateTime now = DateTime.Now;
			long see = seed * seed * seed;
			long sed = 0xFAA3E71 / (now.Second + now.Millisecond * now.Ticks);
			long Reee = 2020;
			long preC = see * sed - Reee * 3141592653;
			long potC = preC + sed * Reee;
			long cracker = potC * see * (long)___IRANDHASG(see);
			if (cracker < 0)
			{ return -cracker; }
			else { return cracker; }

		}
	}
}
