using System;
using x46_varEx.HM;

namespace x46_PWex
{
	public class PWex
	{
		private static string PWS = "";
		public static int POR;

        public static void sPW(string PWD)
        {
			PWS = PWD;
			POR = PASW();
		}
		protected static int PASW()
        {
			return PWS.GetHashCode();
        }
		
	}
}
