using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Base.Models
{
    public class BaseLabel : Label
    {
        public enum ButtonFontSize { Small, Medium, Large }

        public BaseLabel(bool booFocusable) : base()
        {
            this.Focusable = booFocusable;
        }

        public BaseLabel(string strName, string strContent, SolidColorBrush scbForeground, VerticalAlignment enmVerticalAlignment, HorizontalAlignment enmHorizontalAlignment, bool booFocusable, ButtonFontSize enmButtonFontSize) : base()
        {
            this.Name = strName;
            this.Content = strContent;
            this.Foreground = scbForeground;
            this.VerticalAlignment = enmVerticalAlignment;
            this.HorizontalAlignment = enmHorizontalAlignment;
            this.Focusable = booFocusable;

            this.loadBtnFontSize(enmButtonFontSize);
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