using Base.Models;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Base.View
{
    public class CadastroUsuarioView : BaseGrid
    {
        private ColumnDefinition clnDefinition = null;
        private RowDefinition rowDefinition = null;
        private BaseLabel lblViewName = null;
        private BaseGrid bgdViewLine1 = null;
        private BaseLabel lblLogin = null;
        private BaseTextBox tbxLogin = null;
        private BaseLabel lblUsuarioId = null;
        private BaseLabel txtUsuarioId = null;
        private BaseGrid bgdViewLine2 = null;
        private BaseLabel lblSenha = null;
        private BaseTextBox tbxSenha = null;

        public CadastroUsuarioView() : base("CadastroPessoaViewGrid", Theme.Light, true)
        {
            this.loadLayout();
            this.loadControls();
        }

        private void loadLayout()
        {
            this.addRow(1);
            this.addRow(2);
            this.addRow(1);
            this.addRow(16);
        }

        private void loadControls()
        {
            this.loadLblViewName();
            this.loadBgdViewLine1();
            this.loadBgdViewLine2();
        }

        private void loadLblViewName()
        {
            this.lblViewName = new BaseLabel(
                "lblViewName",
                "Cadastro de Usuário",
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

            this.loadLblLogin();
            this.addChildren(ref this.lblLogin, ref this.bgdViewLine1, 1, null);

            this.loadTbxLogin();
            this.addChildren(ref this.tbxLogin, ref this.bgdViewLine1, 2, null);

            this.loadLblUsuarioId();
            this.addChildren(ref this.lblUsuarioId, ref this.bgdViewLine1, 3, null);

            this.loadTxtUsuarioId();
            this.addChildren(ref this.txtUsuarioId, ref this.bgdViewLine1, 4, null);

            this.addChildren(ref this.bgdViewLine1, null, 1);
        }

        private void loadBgdViewLine2()
        {
            this.bgdViewLine2 = new BaseGrid(
                "bgdViewLine2",
                Theme.Light,
                new double?[] { 5, 1, 9, 5 },
                true);

            this.loadLblSenha();
            this.addChildren(ref this.lblSenha, ref this.bgdViewLine2, 1, null);

            this.loadTbxSenha();
            this.addChildren(ref this.tbxSenha, ref this.bgdViewLine2, 2, null);

            this.addChildren(ref this.bgdViewLine2, null, 2);
        }

        private void loadLblLogin()
        {
            this.lblLogin = new BaseLabel(
                "lblLogin",
                "Login:",
                Brushes.White,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Left,
                false,
                BaseLabel.ButtonFontSize.Medium);
        }

        private void loadTbxLogin()
        {
            this.tbxLogin = new BaseTextBox(
                "tbxLogin",
                0.035,
                0.25,
                60,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Left,
                new Thickness(4, 4, 0, 0),
                BaseTextBox.ButtonFontSize.Medium,
                BaseTextBox.Theme.Dark);
        }

        private void loadLblUsuarioId()
        {
            this.lblUsuarioId = new BaseLabel(
                "lblUsuarioId",
                "ID:",
                Brushes.White,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Right,
                false,
                BaseLabel.ButtonFontSize.Medium);
        }

        private void loadTxtUsuarioId()
        {
            this.txtUsuarioId = new BaseLabel(
                "txtUsuarioId",
                "000000",
                Brushes.DarkBlue,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Right,
                false,
                BaseLabel.ButtonFontSize.Medium);
        }

        private void loadLblSenha()
        {
            this.lblSenha = new BaseLabel(
                "lblSenha",
                "Senha:",
                Brushes.White,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Left,
                false,
                BaseLabel.ButtonFontSize.Medium);
        }

        private void loadTbxSenha()
        {
            this.tbxSenha = new BasePasswordBox();
            this.tbxSenha.loadPasswordBox(
                "tbxSenha",
                0.035,
                0.33,
                60,
                VerticalAlignment.Bottom,
                HorizontalAlignment.Left,
                new Thickness(4, 4, 0, 0),
                BasePasswordBox.Theme.Dark,
                BasePasswordBox.ButtonFontSize.Medium);
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