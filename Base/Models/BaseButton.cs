using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Base.Models
{
    public class BaseButton : BaseLabel
    {
        public enum ButtonFontSize { Small, Medium, Large }

        public BaseButton(string strName, string strContent, SolidColorBrush scbForeground, VerticalAlignment enmVerticalAlignment, HorizontalAlignment enmHorizontalAlignment, ButtonFontSize enmBtnFontSize) : base(true)
        {
            this.Name = strName;
            this.Content = strContent;
            this.Foreground = scbForeground;
            this.VerticalAlignment = enmVerticalAlignment;
            this.HorizontalAlignment = enmHorizontalAlignment;
            this.loadBtnFontSize(enmBtnFontSize);
            this.loadStyle();
        }

        public BaseButton(string strName, string strContent, SolidColorBrush scbForeground, VerticalAlignment enmVerticalAlignment, HorizontalAlignment enmHorizontalAlignment, ButtonFontSize enmBtnFontSize, HorizontalAlignment enmHorizontalContentAlignment) : base(true)
        {
            this.Name = strName;
            this.Content = strContent;
            this.Foreground = scbForeground;
            this.VerticalAlignment = enmVerticalAlignment;
            this.HorizontalAlignment = enmHorizontalAlignment;
            this.HorizontalContentAlignment = enmHorizontalContentAlignment;
            this.loadBtnFontSize(enmBtnFontSize);
            this.loadStyle();
        }

        public BaseButton(string strName, string strContent, double dblWidth, SolidColorBrush scbForeground, VerticalAlignment enmVerticalAlignment, HorizontalAlignment enmHorizontalAlignment, ButtonFontSize enmBtnFontSize, HorizontalAlignment enmHorizontalContentAlignment) : base(true)
        {
            this.Name = strName;
            this.Content = strContent;
            this.Width = this.dblWScale(dblWidth);
            this.Foreground = scbForeground;
            this.VerticalAlignment = enmVerticalAlignment;
            this.HorizontalAlignment = enmHorizontalAlignment;
            this.HorizontalContentAlignment = enmHorizontalContentAlignment;
            this.loadBtnFontSize(enmBtnFontSize);
            this.loadStyle();
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

        private void loadStyle()
        {
            try
            {
                Setter btnIsMouseOverSetter = new Setter()
                {
                    Property = Label.FontWeightProperty,
                    Value = FontWeights.Bold
                };

                Trigger btnIsMouseOverTrigger = new Trigger()
                {
                    Property = UIElement.IsMouseOverProperty,
                    Value = true,
                    Setters = { btnIsMouseOverSetter }
                };

                Setter btnIsFocusedSetter = new Setter()
                {
                    Property = Label.FontWeightProperty,
                    Value = FontWeights.Bold
                };

                Trigger btnCIsFocusedTrigger = new Trigger()
                {
                    Property = UIElement.IsFocusedProperty,
                    Value = true,
                    Setters = { btnIsFocusedSetter }
                };

                Style btnIsMouseOverStyle = new Style()
                {
                    Triggers = { btnIsMouseOverTrigger, btnCIsFocusedTrigger }
                };

                this.Style = btnIsMouseOverStyle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}