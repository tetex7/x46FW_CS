﻿using System;
using System.Collections.Generic;
using System.Text;


namespace x46_FW
{
	namespace VarEx
	{
		public class varEx_LM
		{

			public static string ID = "varExLM";
			public static string REV = "R.00.00.01";
			public static int iID = 0xFAA458;


			// a integer limiter
			public static int iIntLi(int inval, int max)
			{
				int val;
				if (inval < 0)
				{ val = -inval; }
				else { val = inval; }
				if (max > val)
				{
					if (inval < 0)
					{ return -val; }
					else { return val; }
				}
				else
				{
					if (inval < 0)
					{ return -max; }
					else { return max; }
				}
			}

			// a float limiter
			public static float IFloatLi(float inval, float max)
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
				else
				{
					if (inval < 0)
					{ return -max; }
					else { return max; }
				}
			}

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

			//a random number generator
			public static long iRand(long seed)
			{
				long see = seed * seed * seed;
				const long sed = 0xFAA3E71;
				long Reee = 2020;
				long preC = see * sed - Reee * 3141592653;
				long potC = preC + sed * Reee;
				long cracker = potC * see;
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



			private static double squer(double _inval)
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
