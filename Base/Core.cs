using Base.View;
using System;

namespace Base
{
    public static class Core
    {
        [STAThread]
        public static int Main()
        {
            try
            {
                HomeView homeView = new HomeView();

                return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
