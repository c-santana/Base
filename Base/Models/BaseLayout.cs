﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace Base.Models
{
    public class BaseLayout : BaseGrid
    {
        UIElement uieChildren = null;

        public BaseLayout() : base("BaseLayoutGrid", false)
        {

            RowDefinition rowDefinitionHeader = new RowDefinition();
            rowDefinitionHeader.Height = new GridLength(1, GridUnitType.Star);
            this.RowDefinitions.Add(rowDefinitionHeader);

            RowDefinition rowDefinitionBody = new RowDefinition();
            rowDefinitionBody.Height = new GridLength(18, GridUnitType.Star);
            this.RowDefinitions.Add(rowDefinitionBody);

            RowDefinition rowDefinitionFooter = new RowDefinition();
            rowDefinitionFooter.Height = new GridLength(1, GridUnitType.Star);
            this.RowDefinitions.Add(rowDefinitionFooter);

            this.addChildren(typeof(BaseHeader), null, 0);
            this.addChildren(typeof(BaseBody), null, 1);
            this.addChildren(typeof(BaseFooter), null, 2);
        }

        public void addChildren(Type type, int? intX = null, int? intY = null)
        {
            try
            {
                this.uieChildren = (UIElement)Activator.CreateInstance(type);

                if (!intX.Equals(null))
                {
                    Grid.SetColumn(this.uieChildren, Convert.ToInt32(intX));
                }
                if(!intY.Equals(null))
                {
                    Grid.SetRow(this.uieChildren, Convert.ToInt32(intY));
                }

                this.Children.Add(uieChildren);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addChildren(ref BaseBody body, int? intX = null, int? intY = null)
        {
            try
            {
                if (!intX.Equals(null))
                {
                    Grid.SetColumn(body, Convert.ToInt32(intX));
                }
                if (!intY.Equals(null))
                {
                    Grid.SetRow(body, Convert.ToInt32(intY));
                }

                this.Children.Add(body);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void changeBody(ref BaseBody body)
        {
            this.Children.Remove(this.FindName("BaseBodyGrid") as UIElement);
            this.addChildren(ref body, null, 1);
        }
    }
}
