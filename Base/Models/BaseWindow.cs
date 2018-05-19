using System;
using System.Windows;

namespace Base.Models
{
    public class BaseWindow : Window
    {
        public enum Layouts { Base, Custom }
        public BaseWindow(string strName, WindowState enmWindowState, WindowStyle enmWindowStyle, Layouts enmLayout, object[] objArgs = null) : base()
        {
            try
            {
                this.Name = strName;
                this.WindowState = enmWindowState;
                this.WindowStyle = enmWindowStyle;
                this.loadLayout(enmLayout, objArgs);
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void loadLayout(Layouts enmLayout, object[] objArgs)
        {
            if(enmLayout.Equals(BaseWindow.Layouts.Base))
            {
                this.Content = Activator.CreateInstance(typeof(BaseLayout), objArgs);
            }
        }
    }
}
