using System;
using System.Collections.Generic;
using System.Text;

namespace x46_FW.varEx
{
    public class limiters
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

		/*public static T iIntLi<T>(T inval, T max)
		{
			T val;
			T Z = 0;
			if ((int)inval < 0)
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
		}*/

	}
}
