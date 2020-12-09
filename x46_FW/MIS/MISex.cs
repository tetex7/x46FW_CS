using System;
using System.Reflection.PortableExecutable;
using x46_FW.MIS;
using x46_FW;
using System.Dynamic;




namespace x46_FW
{
	public class X46FW_MIS
    {
		MISex MIS = new MISex("MISex", 01, true);
    }

	/// <summary>
	/// module identification extension
	/// </summary>
	public class MISex
	{
		private bool _tap;

		readonly private DateTime now = DateTime.Now;
		/// <summary>
		/// module name 
		/// </summary>
		public string m_name { get; private set; }


		/// <summary>
		/// version ID
		/// </summary>
		public string m_vID { get; private set; }

		/// <summary>
		/// module ID
		/// </summary>
		public long m_ID { get; private set; }

		/// <summary>
		/// is it a core module
		/// </summary>
		public bool m_icore { get; private set; }

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

		

		public MISex(string name, long ID, bool icore = false, string vID = "0.0.0")
		{
			_tap = false;
			m_name = name;
			m_ID = ID;
			m_vID = vID;
			m_icore = icore;
			_m_sID = VarEx.varEx_LM.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
		}
	}

}

/*public MISex(string name, long ID, string vID = "0.0.0")
		{
			_tap = false;
			m_name = name;
			m_ID = ID;
			m_icore = false;
			_m_sID = VarEx.varEx_LM.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
		}*/

//protected MISex(){ }


/*public MISex(string name, string vID = "0.0.0")
{
	_tap = true;
	m_name = name;
	_m_sID = VarEx.varEx_LM.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
	m_ID = VarEx.varEx_LM.iRand(now.Minute + now.Second + now.Millisecond + now.Ticks);
	m_icore = false;

}*/
