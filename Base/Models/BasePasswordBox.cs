using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Base.Models
{
    public class BasePasswordBox
    {
        public enum ButtonFontSize { Small, Medium, Large }

        public enum Theme { Dark, Light };

        private PasswordBox objPasswordBox = null;

        public BasePasswordBox()
        {
            objPasswordBox = new PasswordBox();
        }

        public PasswordBox loadPasswordBox(string strName, double dblHeight, double dblWidth, int intMaxLength, VerticalAlignment enmVerticalAlignment, HorizontalAlignment enmHorizontalAlignment, Thickness tcsPadding, Theme enmTheme, ButtonFontSize enmButtonFontSize)
        {
            this.objPasswordBox.Name = strName;
            this.objPasswordBox.PasswordChar = '*';
            this.objPasswordBox.Height = this.dblHScale(dblHeight);
            this.objPasswordBox.Width = this.dblWScale(dblWidth);
            this.objPasswordBox.MaxLength = intMaxLength;
            this.objPasswordBox.VerticalAlignment = enmVerticalAlignment;
            this.objPasswordBox.HorizontalAlignment = enmHorizontalAlignment;
            this.objPasswordBox.Padding = tcsPadding;
            this.loadTheme(enmTheme);
            this.loadBtnFontSize(enmButtonFontSize);

            return this.objPasswordBox;
        }

        private void loadTheme(Theme enmTheme)
        {
            if (enmTheme.Equals(Theme.Dark))
            {
                this.objPasswordBox.BorderThickness = new Thickness(0);
                this.objPasswordBox.BorderBrush = Brushes.Transparent;
                this.objPasswordBox.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#212121"));
                this.objPasswordBox.Foreground = Brushes.White;
                return;
            }
            if (enmTheme.Equals(Theme.Light))
            {
                this.objPasswordBox.BorderThickness = new Thickness(0);
                this.objPasswordBox.BorderBrush = Brushes.Transparent;
                this.objPasswordBox.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#484848"));
                this.objPasswordBox.Foreground = Brushes.White;
                return;
            }
        }

        private double dblHScale(double dbl)
        {
            double dblScale = SystemParameters.WorkArea.Height;

            return (dbl * dblScale);
        }

        private double dblWScale(double dbl)
        {
            double dblScale = SystemParameters.WorkArea.Width;

            return (dbl * dblScale);
        }

        private void loadBtnFontSize(ButtonFontSize enmBtnFontSize)
        {
            switch (enmBtnFontSize)
            {
                case ButtonFontSize.Small:
                    this.objPasswordBox.FontSize = 12;
                    break;

                case ButtonFontSize.Medium:
                    this.objPasswordBox.FontSize = 16;
                    break;

                case ButtonFontSize.Large:
                    this.objPasswordBox.FontSize = 20;
                    break;

                default:
                    break;
            }
        }
    }
}