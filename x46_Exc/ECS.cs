using System;

namespace x46_ExcEx
{
	public class ECS
	{
		public static string GEC = "0xF1";
		public static string IEE = "0x85F";
	}

	namespace XEC
	{
		[Serializable]
		class GenericException : Exception
		{
			public GenericException()
				: base(String.Format(format: "STOPE CODE: {0} ", ECS.GEC))
			{}
		}

		[Serializable]
		class InappropriateEntryException : Exception
		{
			public InappropriateEntryException()
				: base(String.Format("STOPE CODE: {0} ", ECS.GEC))
			{ }
		}
	}
}
