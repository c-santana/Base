using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Base.Models
{
    public class BaseContextMenu : ContextMenu
    {
        private BaseMenuItem bmi = null;
        public enum Theme { Dark, Light };
        public enum MenuItemFontSize { Small, Medium, Large }

        public BaseContextMenu(Theme enmTheme, MenuItemFontSize enmMenuItemFontSize) : base()
        {
            this.loadTheme(enmTheme);
            this.loadMenItemFontSize(enmMenuItemFontSize);
        }

        private void loadTheme(Theme enmTheme)
        {
            if (enmTheme.Equals(Theme.Dark))
            {
                this.Width = (0.15 * SystemParameters.WorkArea.Width);
                this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#212121"));
                this.Foreground = Brushes.White;
                return;
            }
            if (enmTheme.Equals(Theme.Light))
            {
                this.Width = (0.15 * SystemParameters.WorkArea.Width);
                this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#484848"));
                this.Foreground = Brushes.White;
                return;
            }
        }

        private void loadMenItemFontSize(MenuItemFontSize enmBtnFontSize)
        {
            switch (enmBtnFontSize)
            {
                case MenuItemFontSize.Small:
                    this.FontSize = 12;
                    break;

                case MenuItemFontSize.Medium:
                    this.FontSize = 16;
                    break;

                case MenuItemFontSize.Large:
                    this.FontSize = 20;
                    break;

                default:
                    break; 
            }
        }

        public void addItem(string strName, string strHeader, string strIconResourceName)
        {
            this.bmi = new BaseMenuItem(strName, strHeader, strIconResourceName);
            this.Items.Add(this.bmi);
        }

        public void addItem(BaseMenuItem objBaseMenuItem)
        {
            this.Items.Add(objBaseMenuItem);
        }

        public void addItem(List<BaseMenuItem> lstBaseMenuItem)
        {
            foreach (BaseMenuItem item in lstBaseMenuItem)
            {
                this.Items.Add(item);
            }
        }

        public void Open(ref BaseButton uiePlacementTargetName, PlacementMode Placement)
        {
            this.PlacementTarget = uiePlacementTargetName;
            this.Placement = Placement;
            this.IsOpen = true;
        }
    }
}