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
    public class BaseMenuItem : MenuItem
    {
        public delegate void delRoutedEventHandler(object sender, RoutedEventHandler e);

        public BaseMenuItem(string strName, string strHeader) : base()
        {
            this.Name = strName;
            this.Header = strHeader;
            this.loadStyle();
        }

        private void loadStyle()
        {
            try
            {
                Setter bmiIsMouseOverSetterFontWeight = new Setter()
                {
                    Property = Label.FontWeightProperty,
                    Value = FontWeights.Bold
                };

                Trigger bmiIsMouseOverTrigger = new Trigger()
                {
                    Property = UIElement.IsMouseOverProperty,
                    Value = true,
                    Setters = { bmiIsMouseOverSetterFontWeight }
                };

                Setter bmiIsFocusedSetter = new Setter()
                {
                    Property = Label.FontWeightProperty,
                    Value = FontWeights.Bold
                };

                Trigger bmiCIsFocusedTrigger = new Trigger()
                {
                    Property = UIElement.IsFocusedProperty,
                    Value = true,
                    Setters = { bmiIsFocusedSetter }
                };

                Style bmiIsMouseOverStyle = new Style()
                {
                    Triggers = { bmiIsMouseOverTrigger, bmiCIsFocusedTrigger }
                };

                this.Style = bmiIsMouseOverStyle;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
