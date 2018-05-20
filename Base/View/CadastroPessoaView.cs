using Base.Models;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Base.View
{
    public class CadastroPessoaView : BaseGrid
    {
        private ColumnDefinition clnDefinition = null;
        private RowDefinition rowDefinition = null;
        private BaseLabel lblViewName = null;
        private BaseGrid bgdViewLine1 = null;
        private BaseLabel lblNome = null;
        private BaseTextBox tbxNome = null;
        private BaseLabel lblPessoaId = null;
        private BaseLabel txtPessoaId = null;

        public CadastroPessoaView() : base("CadastroPessoaViewGrid", Theme.Light, true)
        {
            this.loadLayout();
            this.loadControls();
        }

        private void loadLayout()
        {
            this.addRow(1);
            this.addRow(2);
            this.addRow(17);
        }

        private void loadControls()
        {
            this.loadLblViewName();
            this.loadBgdViewLine1();
        }

        private void loadLblViewName()
        {
            this.lblViewName = new BaseLabel(
                "lblViewName",
                "Cadastro de Pessoa.",
                Brushes.White,
                VerticalAlignment.Center,
                HorizontalAlignment.Center,
                false,
                BaseLabel.ButtonFontSize.Large);

            this.addChildren(ref this.lblViewName, null, 0);
        }

        private void loadBgdViewLine1()
        {
            this.bgdViewLine1 = new BaseGrid(
                "bgdViewLine1",
                Theme.Light,
                new double?[] { 5, 1, 7, 1, 1, 5 },
                true);

            this.loadLblNome();
            this.addChildren(ref this.lblNome, ref this.bgdViewLine1, 1, null);

            this.loadTbxNome();
            this.addChildren(ref this.tbxNome, ref this.bgdViewLine1, 2, null);

            this.loadLblPessoaId();
            this.addChildren(ref this.lblPessoaId, ref this.bgdViewLine1, 3, null);

            this.loadTxtPessoaId();
            this.addChildren(ref this.txtPessoaId, ref this.bgdViewLine1, 4, null);

            this.addChildren(ref this.bgdViewLine1, null, 1);
        }

        private void loadLblNome()
        {
            this.lblNome = new BaseLabel(
                "lblNome",
                "Nome:",
                Brushes.White,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Left,
                false,
                BaseLabel.ButtonFontSize.Medium);
        }

        private void loadTbxNome()
        {
            this.tbxNome = new BaseTextBox(
                "tbxNome",
                0.035,
                0.33,
                60,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Left,
                new Thickness(4, 4, 0, 0),
                BaseTextBox.ButtonFontSize.Medium,
                BaseTextBox.Theme.Dark);
        }

        private void loadLblPessoaId()
        {
            this.lblPessoaId = new BaseLabel(
                "lblPessoaId",
                "PessoaID:",
                Brushes.White,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Right,
                false,
                BaseLabel.ButtonFontSize.Medium);
        }

        private void loadTxtPessoaId()
        {
            this.txtPessoaId = new BaseLabel(
                "txtPessoaId",
                "000000",
                Brushes.DarkBlue,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Right,
                false,
                BaseLabel.ButtonFontSize.Medium);
        }

        public void addChildren(ref BaseTextBox tbxChildren, ref BaseGrid bgdParent, int? intX = null, int? intY = null)
        {
            try
            {
                if (!intX.Equals(null))
                {
                    Grid.SetColumn(tbxChildren, Convert.ToInt32(intX));
                }
                if (!intY.Equals(null))
                {
                    Grid.SetRow(tbxChildren, Convert.ToInt32(intY));
                }

                bgdParent.Children.Add(tbxChildren);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addChildren(ref BaseLabel lblChildren, ref BaseGrid bgdParent, int? intX = null, int? intY = null)
        {
            try
            {
                if (!intX.Equals(null))
                {
                    Grid.SetColumn(lblChildren, Convert.ToInt32(intX));
                }
                if (!intY.Equals(null))
                {
                    Grid.SetRow(lblChildren, Convert.ToInt32(intY));
                }

                bgdParent.Children.Add(lblChildren);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addChildren(ref BaseLabel lblChildren, int? intX = null, int? intY = null)
        {
            try
            {
                if (!intX.Equals(null))
                {
                    Grid.SetColumn(lblChildren, Convert.ToInt32(intX));
                }
                if (!intY.Equals(null))
                {
                    Grid.SetRow(lblChildren, Convert.ToInt32(intY));
                }

                this.Children.Add(lblChildren);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addChildren(ref BaseGrid bgdChildren, int? intX = null, int? intY = null)
        {
            try
            {
                if (!intX.Equals(null))
                {
                    Grid.SetColumn(bgdChildren, Convert.ToInt32(intX));
                }
                if (!intY.Equals(null))
                {
                    Grid.SetRow(bgdChildren, Convert.ToInt32(intY));
                }

                this.Children.Add(bgdChildren);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void addColumn(double dblWidth)
        {
            this.clnDefinition = new ColumnDefinition();
            this.clnDefinition.Width = new GridLength(dblWidth, GridUnitType.Star);
            this.ColumnDefinitions.Add(this.clnDefinition);
        }

        private void addRow(double dblHeight)
        {
            this.rowDefinition = new RowDefinition();
            this.rowDefinition.Height = new GridLength(dblHeight, GridUnitType.Star);
            this.RowDefinitions.Add(this.rowDefinition);
        }
    }
}