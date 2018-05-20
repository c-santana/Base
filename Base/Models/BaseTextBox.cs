using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Base.Models
{
    public class BaseTextBox : TextBox
    {
        public enum ButtonFontSize { Small, Medium, Large }
        public enum Theme { Dark, Light };

        public BaseTextBox(string strName, double dblHeight, double dblWidth, int intMaxLength, VerticalAlignment enmVerticalAlignment, HorizontalAlignment enmHorizontalAlignment, Thickness tcsPadding, ButtonFontSize enmButtonFontSize, Theme enmTheme) : base()
        {
            this.Name = strName;
            this.Height = this.dblHScale(dblHeight);
            this.Width = this.dblWScale(dblWidth);
            this.VerticalAlignment = enmVerticalAlignment;
            this.HorizontalAlignment = enmHorizontalAlignment;
            this.Padding = tcsPadding;
            this.loadBtnFontSize(enmButtonFontSize);
            this.loadTheme(enmTheme);
            this.MaxLength = intMaxLength;
        }

        private void loadTheme(Theme enmTheme)
        {
            if (enmTheme.Equals(Theme.Dark))
            {
                this.BorderThickness = new Thickness(0);
                this.BorderBrush = Brushes.Transparent;
                this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#212121"));
                this.Foreground = Brushes.White;
                return;
            }
            if (enmTheme.Equals(Theme.Light))
            {
                this.BorderThickness = new Thickness(0);
                this.BorderBrush = Brushes.Transparent;
                this.Background = (SolidColorBrush)(new BrushConverter().ConvertFrom("#484848"));
                this.Foreground = Brushes.White;
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
                    this.FontSize = 12;
                    break;

                case ButtonFontSize.Medium:
                    this.FontSize = 16;
                    break;

                case ButtonFontSize.Large:
                    this.FontSize = 20;
                    break;

                default:
                    break;
            }
        }
    }
}
