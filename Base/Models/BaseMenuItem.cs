using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Base.Libs;

namespace Base.Models
{
    public class BaseMenuItem : MenuItem
    {
        public BaseMenuItem(string strName, string strHeader, string strIconResourceName) : base()
        {
            this.Name = strName;
            this.Header = strHeader;
            this.loadIcon(strIconResourceName);
            this.loadStyle();
        }

        private void loadIcon(string strIconResourceName)
        {
            Stream stm = ManifestResources.GetManifestResource(strIconResourceName);
            Image img = ByteImageConverter.StreamToImage(stm);
            img.Width = 20;
            img.Height = 20;
            img.HorizontalAlignment = HorizontalAlignment.Stretch;
            img.VerticalAlignment = VerticalAlignment.Stretch;
            this.Icon = img;
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
