using System.Windows.Controls;
using System.Windows.Media;

namespace Base.Models
{
    public class BaseGrid : Grid
    {
        public enum Theme { Dark, Light };

        public BaseGrid(string strName, Theme enmTheme, bool booShowGridLines) : base()
        {
            this.Name = strName;
            this.loadTheme(enmTheme, booShowGridLines);
        }

        public BaseGrid(string strName, bool booShowGridLines) : base()
        {
            this.Name = strName;
            this.ShowGridLines = booShowGridLines;
        }

        private void loadTheme(Theme enmTheme, bool booShowGridLine)
        {
            if (enmTheme.Equals(Theme.Dark))
            {
                this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#212121"));
                this.ShowGridLines = booShowGridLine;
                return;
            }
            if (enmTheme.Equals(Theme.Light))
            {
                this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#484848"));
                this.ShowGridLines = booShowGridLine;
                return;
            }
        }
    }
}