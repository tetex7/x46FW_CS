using System;
using System.Collections.Generic;
using System.Text;

namespace x46_FW.varEx
{
    public class HL_math
    {
		public static double POWR(int iny, int pow)
		{
			int outy = iny;
			//double ff = iny;
			for (uint i = 0; i < pow; i++)
			{
				outy *= iny;
			}
			return outy;
		}

		public static int squer(int _inval)
		{
			int inv = _inval;
			int por = inv * inv;
			return por;
		}

		public static int cuber(int _inv)
		{
			int inv = _inv;
			int por = inv * inv * inv;
			return por;
		}
	}
}
