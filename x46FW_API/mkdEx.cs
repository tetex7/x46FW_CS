using System;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using System.Dynamic;
using System.Resources;
using System.IO;
using System.Text;
using System.Text.Encodings;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.RegularExpressions;

namespace x46FW_API
{
    public class mkdEx
    {
        public static void MKdir()
        {
            string folderName = @"c:\x46_API";
            System.IO.Directory.CreateDirectory(folderName);
            if (!System.IO.Directory.Exists(folderName))
            {
            }
            else
            {
                Console.WriteLine("folder \"{0}\" already exists.", folderName);
                return;
            }
        }

        public static void MKjson(string fname)
        {
            string ff = ".json";
            string name = string.Format("{0}{1}", fname, ff);
            string folderName = @"c:\x46_API";

            if (System.IO.Directory.Exists(folderName))
            {
                if (!System.IO.File.Exists(name))
                {
                    string gg = string.Format("{0}{1}{2}", folderName, @"\", name);
                    File.Create(gg);
                }
                else
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("folder \"{0}\" dos not exists.", folderName);
                return;
            }
}
    }
}
