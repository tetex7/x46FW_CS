using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace x46_FW
{
	namespace varEx
	{
		public class UT
		{
			public long unsTs(ulong IN)
			{
				return (long)IN;
			}
		}


		public class varEx_LM
		{

			public static string ID = "varExLM";
			public static string REV = "R.00.00.01";
			public static int iID = 0xFAA458;

			// a float limiter
			public static float iFloatLi(float inval, float max)
			{
				float val;
				if (inval < 0) { val = -inval; }
				else { val = inval; }
				if (max > val)
				{
					if (inval < 0)
					{ return -val; }
					else { return val; }
				}

				{
					if (inval < 0)
					{ return -max; }
					else { return max; }
				}
			}

			private static long ___IRANDHASG(long Sseed)
			{
				long rt = Sseed.ToString().GetHashCode();
				return rt;
			}


			//a random number generator
			public static long iRand(long seed)
			{
				DateTime now = DateTime.Now;
				long see = seed * seed * seed;
				long sed = 0xFAA3E71 / (now.Second + now.Millisecond * now.Ticks);
				long Reee = 2020;
				long preC = see * sed - Reee * 3141592653;
				long potC = preC + sed * Reee;
				long cracker = potC * see * ___IRANDHASG(see);
				if (cracker < 0)
				{ return -cracker; }
				else { return cracker; }
				
			}
		}

		class varEx_HM
		{
			public static string ID = "varExHM";
			public static string REV = "R.00.00.01";
			public static int iID = 0xFAA458;

			public static double POWR(int iny, int pow)
			{
				double outy = iny;
				//double ff = iny;
				for (uint i = 0; i < pow; i++)
				{
					outy *= iny;
				}
				return outy;
			}

			public static double squer(double _inval)
			{
				double inv = _inval;
				double por = inv * inv;
				return por;
			}

			public static double cuber(double _inv)
			{
				double inv = _inv;
				double por = inv * inv * inv;
				return por;
			}

			
		}
	}
}
