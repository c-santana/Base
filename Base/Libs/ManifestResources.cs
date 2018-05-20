using System;
using System.IO;
using System.Reflection;

namespace Base.Libs
{
    public class ManifestResources
    {
        private static Assembly _assembly = null;

        public static Assembly assembly
        {
            get
            {
                if (_assembly == null)
                {
                    _assembly = Assembly.GetExecutingAssembly();
                }

                return _assembly;
            }
        }

        static ManifestResources()
        {
        }

        public static Stream GetManifestResource(string strName)
        {
            try
            {
                string[] strResNames =  assembly.GetManifestResourceNames();
                foreach (string item in strResNames)
                {
                    if(item.Equals(strName))
                    {

                    }
                }
                Stream stm = assembly.GetManifestResourceStream(strName);
                return stm;
            }
            catch (Exception ex)
            {
                Type type = ex.GetType();
                switch (type)
                {
                    default:
                        throw ex;
                }
            }
        }
    }
}