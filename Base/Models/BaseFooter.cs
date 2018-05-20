using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Base.Models
{
    public class BaseFooter : BaseGrid
    {
        // Atributos

        private BaseLabel lblDesenvolvimento = null;
        private BaseLabel lblDataBase = null;
        private ColumnDefinition clnDefinition = null;

        // Ctor

        public BaseFooter() : base("BaseFooterGrid", BaseGrid.Theme.Dark, true)
        {
            this.loadLayout();
            this.loadControls();
        }

        // Métodos

        private void addColumn(double dblWidth)
        {
            this.clnDefinition = new ColumnDefinition();
            this.clnDefinition.Width = new GridLength(dblWidth, GridUnitType.Star);
            this.ColumnDefinitions.Add(this.clnDefinition);
        }

        private void loadLayout()
        {
            this.addColumn(0.24);
            this.addColumn(9.76);
            this.addColumn(9.76);
            this.addColumn(0.24);
        }

        private void loadControls()
        {
            this.loadLblDesenvolvimento();
            this.loadLblDataBase();
        }

        private void loadLblDesenvolvimento()
        {
            this.lblDesenvolvimento = new BaseLabel(
                    "lblDesenvolvimento",
                    "Desenvolvido por CG-Dev.",
                    Brushes.White,
                    VerticalAlignment.Center,
                    HorizontalAlignment.Left,
                    false,
                    BaseLabel.ButtonFontSize.Medium);

            this.addChildren(ref this.lblDesenvolvimento, 1, null);
        }

        private void loadLblDataBase()
        {
            this.lblDataBase = new BaseLabel(
                    "lblDataBase",
                    $"Banco de dados: 'BancoDeDados'.",
                    Brushes.White,
                    VerticalAlignment.Center,
                    HorizontalAlignment.Right,
                    false,
                    BaseLabel.ButtonFontSize.Medium);

            this.addChildren(ref this.lblDataBase, 2, null);
        }

        public void addChildren(ref BaseLabel btnChildren, int? intX = null, int? intY = null)
        {
            try
            {
                if (!intX.Equals(null))
                {
                    Grid.SetColumn(btnChildren, Convert.ToInt32(intX));
                }
                if (!intY.Equals(null))
                {
                    Grid.SetRow(btnChildren, Convert.ToInt32(intY));
                }

                this.Children.Add(btnChildren);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}