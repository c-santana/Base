using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Base.Models
{
    public class BaseGrid : Grid
    {
        private RowDefinition rowDefinition = null;
        private ColumnDefinition clnDefinition = null;

        public enum Theme { Dark, Light };

        public BaseGrid(string strName, Theme enmTheme, bool booShowGridLines) : base()
        {
            this.Name = strName;
            this.loadTheme(enmTheme, booShowGridLines);
        }

        public BaseGrid(string strName, Theme enmTheme, double?[] dblClnHeight, bool booShowGridLines) : base()
        {
            this.Name = strName;
            this.loadTheme(enmTheme, booShowGridLines);
            foreach (double dblHeight in dblClnHeight)
            {
                this.addColumn(dblHeight);
            }
        }

        public BaseGrid(string strName, bool booShowGridLines) : base()
        {
            this.Name = strName;
            this.ShowGridLines = booShowGridLines;
        }

        private void addRow(double dblHeight)
        {
            this.rowDefinition = new RowDefinition();
            this.rowDefinition.Height = new GridLength(dblHeight, GridUnitType.Star);
            this.RowDefinitions.Add(this.rowDefinition);
        }

        private void addColumn(double dblWidth)
        {
            this.clnDefinition = new ColumnDefinition();
            this.clnDefinition.Width = new GridLength(dblWidth, GridUnitType.Star);
            this.ColumnDefinitions.Add(this.clnDefinition);
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