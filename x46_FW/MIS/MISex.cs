using System;
using System.Reflection.PortableExecutable;
using x46_FW.MIS;
using x46_FW;


//module identification extension

namespace x46_FW
{
	public class MISex
	{
		private bool _tap;

		readonly private DateTime now = DateTime.Now;
		//module name
		public string m_name { get; private set; }

		
		//module ID
		public long m_ID { get; private set; }

		//is a core module
		public bool m_icore;

		private long _m_sID;

		public long gM_ID()
        {
			if (_tap == true)
            {
				return VarEx.varEx_LM.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
			}
			else if (m_icore == true && _tap == false)
            {
				return _m_sID;
            }
			else
            {
				return VarEx.varEx_LM.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
			}
        }

		public MISex(string name, long ID)
        {
			_tap = false;
			m_name = name;
			m_ID = ID;
			m_icore = false;
			_m_sID = VarEx.varEx_LM.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
		}

		public MISex(string name, long ID, bool icore)
		{
			_tap = false;
			m_name = name;
			m_ID = ID;
			m_icore = icore;
			_m_sID = VarEx.varEx_LM.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
		}
	}

}
