using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Base.Models
{
    public class BaseTextBox : TextBox
    {
        public enum ButtonFontSize { Small, Medium, Large }

        public BaseTextBox(string strName, double dblHeight, double dblWidth, VerticalAlignment enmVerticalAlignment, HorizontalAlignment enmHorizontalAlignment, ButtonFontSize enmButtonFontSize) : base()
        {
            this.Name = strName;
            this.Height = this.dblHScale(dblHeight);
            this.Width = this.dblWScale(dblWidth);
            this.VerticalAlignment = enmVerticalAlignment;
            this.HorizontalAlignment = enmHorizontalAlignment;
            this.loadBtnFontSize(enmButtonFontSize);
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
