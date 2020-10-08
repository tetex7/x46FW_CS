using System;
using System.Collections.Generic;
using System.Text;

namespace x46_FW.MIS
{
    namespace MIS_EXS
    {
        [Serializable]
        class ModuleNotFoundException : Exception
        {
            public ModuleNotFoundException()
            {

            }

            public ModuleNotFoundException(string name)
                : base(String.Format("Module Not Found Exception: {0}", name))
            {

            }

        }
    }
}
