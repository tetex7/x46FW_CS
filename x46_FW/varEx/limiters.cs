using System;
using System.Collections.Generic;
using System.Text;
using x46_FW.core;


namespace x46_FW.varEx
{
	[MISex("limiters", 0xF5, "1.1.0")]
    public static class limiters
    {

		/// <summary>
		/// a integer limiter
		/// </summary>
		/// <param name="inval">in val</param>
		/// <param name="max">max val</param>
		/// <returns>max_out val</returns>
		public static int iIntLi(int inval, int max)
		{
			int val;
			if (inval < 0)
			{ val = -inval; }
			else { val = inval; }
			if (max >= val)
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

		/// <summary>
		/// a float limiter
		/// </summary>
		/// <param name="inval">in val</param>
		/// <param name="max">max val</param>
		/// <returns>max_out val</returns>
		public static float IFloatLi(float inval, float max)
		{
			float val;
			if (inval < 0) { val = -inval; }
			else { val = inval; }
			if (max >= val)
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

		/// <summary>
		/// a Decimal limiter
		/// </summary>
		/// <param name="inval">in val</param>
		/// <param name="max">max val</param>
		/// <returns>max_out val</returns>
		public static decimal iDECLi(decimal inval, decimal max)
		{
			decimal val;
			if (inval < 0)
			{ val = -inval; }
			else { val = inval; }
			if (max >= val)
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

		/// <summary>
		/// a Decimal limiter
		/// </summary>
		/// <param name="inval">in val</param>
		/// <param name="max">max val</param>
		/// <returns>max_out val</returns>
		public static long iDECLi(long inval, long max)
		{
			long val;
			if (inval < 0)
			{ val = -inval; }
			else { val = inval; }
			if (max >= val)
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

		/// <summary>
		/// a Decimal limiter
		/// </summary>
		/// <param name="inval">in val</param>
		/// <param name="max">max val</param>
		/// <returns>max_out val</returns>
		public static double iDOULi(double inval, double max)
		{
			double val;
			if (inval < 0)
			{ val = -inval; }
			else { val = inval; }
			if (max >= val)
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

	}
}
