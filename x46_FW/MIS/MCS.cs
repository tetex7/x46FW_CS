using System;
using System.Collections.Generic;
using System.Text;

namespace x46_FW.core
{
    [MISex("MCS", 0x156FF, "0.0.F", true)]
    public static class MCS
    {
        public static ulong gID<T>() where T : class
        {
            Type R = typeof(T);
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(R);
            foreach (System.Attribute attr in attrs)
            {
                if (attr is MISexAttribute)
                {
                    MISexAttribute a = (MISexAttribute)attr;
                    return a.m_ID;
                }
            }
            return 0;
        }

        public static string gNAME<T>() where T : class
        {
            Type R = typeof(T);
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(R);
            foreach (System.Attribute attr in attrs)
            {
                if (attr is MISexAttribute)
                {
                    MISexAttribute a = (MISexAttribute)attr;
                    return a.m_name;
                }
            }
            return "404";
        }

        public static string gVID<T>() where T : class
        {
            Type R = typeof(T);
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(R);
            foreach (System.Attribute attr in attrs)
            {
                if (attr is MISexAttribute)
                {
                    MISexAttribute a = (MISexAttribute)attr;
                    return a.m_vID;
                }
            }
            return "404";
        }

        public static bool ISC<T>() where T : class
        {
            Type R = typeof(T);
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(R);
            foreach (System.Attribute attr in attrs)
            {
                if (attr is MISexAttribute)
                {
                    MISexAttribute a = (MISexAttribute)attr;
                    return a.m_icore;
                }
            }
            return false;
        }

        public static MISexAttribute fMOD<T>() where T : class
        {
            Type R = typeof(T);
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(R);
            foreach (System.Attribute attr in attrs)
            {
                if (attr is MISexAttribute)
                {
                    MISexAttribute a = (MISexAttribute)attr;
                    return a;
                }
                else
                {
                    throw new x46_FW.MIS.EXC.ModuleNotFoundException("x");
                }
            }
            return null;
        }
    }
}
