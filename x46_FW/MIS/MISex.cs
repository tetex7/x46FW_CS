using System;
using System.Reflection.PortableExecutable;
using x46_FW.MIS;
using x46_FW;


//module identification extension

namespace x46_FW
{
	public class MISex
	{
		readonly private DateTime now = DateTime.Now;
		//module name
		public string m_name { get; private set; }

		
		//module ID
		public uint m_ID { get; private set; }

		//is a core module
		public bool m_icore { get; private set; }

		public long m_sID { get; private set; }


		public MISex(string name, uint ID)
        {
			m_name = name;
			m_ID = ID;
			m_icore = false;
			m_sID = VarEx.varEx_LM.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * (long)m_name.GetHashCode()));
		}

		public MISex(string name, uint ID, bool icore)
		{
			m_name = name;
			m_ID = ID;
			m_icore = icore;
			m_sID = VarEx.varEx_LM.iRand(now.Hour + now.Minute + now.Second / (m_ID * now.Ticks));
		}
	}

}
