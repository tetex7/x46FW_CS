using System;
using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using System.Dynamic;
using System.Resources;
using System.Text.Unicode;
using System.Text.RegularExpressions;
using x46FW_WFE.SFS;
using System.Xml.Schema;
using System.Xml;
using System.Xml.Resolvers;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Serialization;

namespace x46FW_WFE
{
	public class WLUex
	{
		private char[] FG;
		private string[] dre;

		private void looker(char[] hh)
		{
			SFSex.MMDR();
			string path = @"C:\x46" + @"\mae.xml";

			try
			{
				// Create the file, or overwrite if the file exists.
				using (FileStream fs = File.Create(path))
				{
					byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
					// Add some information to the file.
					fs.Write(info, 0, info.Length);
				}
			}

			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}

		private void geter()
        {
			using ()
        }

		public WLUex(char[] LOOK)
		{
			FG = LOOK;
		}
	}
}
