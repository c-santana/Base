using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sys.Libs
{

    public class ManifestResources
    {
        private Assembly _assembly = null;
        private List<string> _lstManifestResources = null;
        private List<string> _lstManifestResourcesNames = null;

        private void Initialize()
        {
            try
            {
                // Get assembly
                this._assembly = Assembly.GetExecutingAssembly();

                // Get manifest resources list
                this._lstManifestResources = new List<string>();
                this._lstManifestResources = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames().ToList<string>();

                // Set manifest resources names list
                this._lstManifestResourcesNames = new List<string>();
                this._lstManifestResourcesNames.Add("Sys.Imagens.bookshelf.png");

                // Manifest resources validation
                if(!this.Validation())
                {
                    throw new ArgumentNullException();
                }
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

        private bool Validation()
        {
            int intCount = 0;
            int intResourcesFind = 0;
            int intResourcesToFind = 0;

            try
            {
                intResourcesToFind = this._lstManifestResourcesNames.Count;

                foreach (string resourceName in this._lstManifestResourcesNames)
                {
                    if (this._lstManifestResources.Contains(resourceName))
                    {
                        intResourcesFind++;
                    }

                    intCount++;
                }

                if(intResourcesFind.Equals(intResourcesToFind))
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public ManifestResources()
        {
            this.Initialize();
        }

        public Stream GetManifestResource(string name)
        {
            try
            {
                return this._assembly.GetManifestResourceStream(name);
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
