using System;
using System.Collections.Generic;
using System.Text;

namespace x46_FW.MIS
{
	namespace EXC
	{
		[Serializable]
		public class ModuleNotFoundException : Exception
		{
			private ModuleNotFoundException()
			{ }

			public ModuleNotFoundException(string name)
				: base(String.Format("Module_Not_Found_Exception: {0}", name)) { }
		}

		[Serializable]
		public class ModuleGenericException : Exception
		{
			/*private*/ public ModuleGenericException(){ }

			public ModuleGenericException(string name)
				: base(String.Format("Module_Name: {0}", name)) { }
		}
	}
}
