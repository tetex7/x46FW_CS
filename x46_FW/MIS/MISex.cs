using System;
using System.Reflection.PortableExecutable;
using x46_FW.MIS;
using x46_FW;
using System.Dynamic;




namespace x46_FW.core
{
	/// <summary>
	/// module identification extension
	/// </summary>
	/*public class MISex
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
				return varEx.RAND.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
			}
			else if (m_icore == true && _tap == false)
			{
				return _m_sID;
			}
			else
			{
				return varEx.RAND.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
			}
		}

		

		public MISex(string name, long ID, bool icore = false, string vID = "0.0.0")
		{
			_tap = false;
			m_name = name;
			m_ID = ID;
			m_vID = vID;
			m_icore = icore;
			_m_sID = varEx.RAND.iRand(now.Minute + now.Second + now.Millisecond / (m_ID * m_name.GetHashCode()));
		}
	}*/


	/// <summary>
	/// module identification extension Attribute
	/// </summary>
	[System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false)]
	public class MISexAttribute : System.Attribute
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
		public ulong m_ID { get; private set; }

		/// <summary>
		/// is it a core module
		/// </summary>
		public bool m_icore { get; private set; }

		private long _m_sID;

		public long gM_ID()
		{
			if (_tap == true)
			{
				return varEx.RAND.iRand(now.Minute + now.Second + now.Millisecond / ((long)m_ID * m_name.GetHashCode()));
			}
			else if (m_icore == true && _tap == false)
			{
				return _m_sID;
			}
			else
			{
				return varEx.RAND.iRand(now.Minute + now.Second + now.Millisecond / ((long)m_ID * m_name.GetHashCode()));
			}
		}


		/// <summary>
		/// module identification extension
		/// </summary>
		/// <param name="name">string name</param>
		/// <param name="ID">64bit ID</param>
		/// <param name="icore">is a core module</param>
		/// <param name="vID">version ID</param>
		public MISexAttribute(string name, ulong ID, string vID = "0.0.0", bool icore = false)
		{
			_tap = false;
			m_name = name;
			m_ID = ID;
			m_vID = vID;
			m_icore = icore;
			_m_sID = varEx.RAND.iRand(now.Minute + now.Second + now.Millisecond / ((long)m_ID * m_name.GetHashCode()));
		}
	}

}
