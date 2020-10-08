using System;
using x46_FW.MIS;


//module identification extension

namespace x46_FW
{
	public class MISex
	{
		//module name
		public string m_name { get; }

		
		//module ID
		public uint m_ID { get; }

		//is a core module
		public bool m_icore { get; }

		public MISex(string name, uint ID)
        {
			m_name = name;
			m_ID = ID;
			m_icore = false;
		}

		public MISex(string name, uint ID, bool icore)
		{
			m_name = name;
			m_ID = ID;
			m_icore = icore;
		}
	}

}
