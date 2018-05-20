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
    public class BaseBody : BaseGrid
    {
        private ColumnDefinition clnDefinition = null;

        public BaseBody() : base("BaseBodyGrid", BaseGrid.Theme.Light, true)
        {
            this.loadLayout();
            this.loadControls();
        }

        private void addColumn(double dblWidth)
        {
            this.clnDefinition = new ColumnDefinition();
            this.clnDefinition.Width = new GridLength(dblWidth, GridUnitType.Star);
            this.ColumnDefinitions.Add(this.clnDefinition);
        }

        private void loadLayout()
        {
            this.addColumn(0.24);
            this.addColumn(19.52);
            this.addColumn(0.24);
        }

        private void loadControls()
        {
            
        }
    }
}
