using System;
using System.Collections.Generic;
using System.Text;

namespace x46_FW.MIS
{
    namespace MIS_EXS
    {
        [Serializable]
        public class ModuleNotFoundException : Exception
        {
            private ModuleNotFoundException()
            {

            }

            public ModuleNotFoundException(string name)
                : base(String.Format("Module Not Found Exception: {0}", name))
            {

            }

        }
    }
}
