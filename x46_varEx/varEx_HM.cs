using System;
using System.Collections.Generic;
using System.Text;

namespace x46_varEx
{
	namespace HM
	{
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
