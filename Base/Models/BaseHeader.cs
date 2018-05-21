using Base.View;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Base.Models
{
    public class BaseHeader : BaseGrid
    {
        // Atributos

        private BaseButton btnCadastro = null;
        private BaseButton btnConsulta = null;
        private BaseButton btnConfig = null;
        private BaseContextMenu bcm = null;
        private BaseMenuItem bmi = null;
        private ColumnDefinition clnDefinition = null;

        // Ctor

        public BaseHeader() : base("BaseHeaderGrid", BaseGrid.Theme.Dark, true)
        {
            this.loadLayout();
            this.loadControls();
        }

        // Métodos

        public void addChildren(ref BaseButton btnChildren, int? intX = null, int? intY = null)
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

        private void addColumn(double dblWidth)
        {
            this.clnDefinition = new ColumnDefinition();
            this.clnDefinition.Width = new GridLength(dblWidth, GridUnitType.Star);
            this.ColumnDefinitions.Add(this.clnDefinition);
        }

        private void loadLayout()
        {
            this.addColumn(0.24);
            this.addColumn(1.00);
            this.addColumn(1.00);
            this.addColumn(16.52);
            this.addColumn(1.00);
            this.addColumn(0.24);
        }

        private void loadControls()
        {
            this.loadBtnCadastro();
            this.loadBtnConsulta();
            this.loadBtnConfig();
        }

        private void loadBtnCadastroBCM()
        {
            this.bcm = new BaseContextMenu(BaseContextMenu.Theme.Dark, BaseContextMenu.MenuItemFontSize.Medium);

            this.bmi = new BaseMenuItem("bmiCadastroPessoa", "Pessoa", "Base.Icons.manager.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiCadastroPessoa_Click);
            this.bcm.addItem(this.bmi);

            this.bmi = new BaseMenuItem("bmiCadastroUsuario", "Usuario", "Base.Icons.cube.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiCadastroUsuario_Click);
            this.bcm.addItem(this.bmi);

            this.bmi = new BaseMenuItem("bmiCadastroCliente", "Cliente", "Base.Icons.box.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiCadastroCliente_Click);
            this.bcm.addItem(this.bmi);

            this.bmi = new BaseMenuItem("bmiCadastroFornecedor", "Fornecedor", "Base.Icons.rack.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiCadastroFornecedor_Click);
            this.bcm.addItem(this.bmi);

            this.bcm.Open(ref this.btnCadastro, PlacementMode.Bottom);
        }

        private void loadBtnConsultaBCM()
        {
            this.bcm = new BaseContextMenu(BaseContextMenu.Theme.Dark, BaseContextMenu.MenuItemFontSize.Medium);

            this.bmi = new BaseMenuItem("bmiConsultaPessoa", "Pessoa", "Base.Icons.manager.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiConsultaPessoa_Click);
            this.bcm.addItem(this.bmi);

            this.bmi = new BaseMenuItem("bmiConsultaProduto", "Produto", "Base.Icons.cube.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiConsultaProduto_Click);
            this.bcm.addItem(this.bmi);

            this.bmi = new BaseMenuItem("bmiConsultaCaixa", "Caixa", "Base.Icons.box.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiConsultaCaixa_Click);
            this.bcm.addItem(this.bmi);

            this.bmi = new BaseMenuItem("bmiConsultaPrateleira", "Prateleira", "Base.Icons.rack.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiConsultaPrateleira_Click);
            this.bcm.addItem(this.bmi);

            this.bmi = new BaseMenuItem("bmiConsultaEstante", "Estante", "Base.Icons.shelves.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiConsultaEstante_Click);
            this.bcm.addItem(this.bmi);

            this.bcm.Open(ref this.btnConsulta, PlacementMode.Bottom);
        }

        private void loadBtnConfigBCM()
        {
            this.bcm = new BaseContextMenu(BaseContextMenu.Theme.Dark, BaseContextMenu.MenuItemFontSize.Medium);

            this.bmi = new BaseMenuItem("bmiConfigConexao", "Conexão", "Base.Icons.database.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiConfigConexao_Click);
            this.bcm.addItem(this.bmi);

            this.bmi = new BaseMenuItem("bmiConfigSobre", "Sobre", "Base.Icons.about.png");
            this.bmi.Click += new RoutedEventHandler(this.bmiConfigSobre_Click);
            this.bcm.addItem(this.bmi);

            this.bcm.Open(ref this.btnConfig, PlacementMode.Bottom);
        }

        private void loadBtnCadastro()
        {
            this.btnCadastro = new BaseButton(
                    "btnCadastro",
                    "Cadastro",
                    Brushes.White,
                    VerticalAlignment.Center,
                    HorizontalAlignment.Left,
                    BaseButton.ButtonFontSize.Medium);

            this.btnCadastro.ContextMenu = this.bcm;

            this.btnCadastro.MouseLeftButtonDown += this.btnCadastro_MouseLeftButtonDown;

            this.addChildren(ref this.btnCadastro, 1, null);
        }

        private void loadBtnConsulta()
        {
            this.btnConsulta = new BaseButton(
                    "btnConsulta",
                    "Consulta",
                    Brushes.White,
                    VerticalAlignment.Center,
                    HorizontalAlignment.Left,
                    BaseButton.ButtonFontSize.Medium);

            this.btnConsulta.MouseLeftButtonDown += this.btnConsulta_MouseLeftButtonDown;

            this.addChildren(ref this.btnConsulta, 2, null);
        }

        private void loadBtnConfig()
        {
            this.btnConfig = new BaseButton(
                    "btnConfig",
                    "Config",
                    Brushes.White,
                    VerticalAlignment.Center,
                    HorizontalAlignment.Right,
                    BaseButton.ButtonFontSize.Medium);

            this.btnConfig.MouseLeftButtonDown += this.btnConfig_MouseLeftButtonDown;

            this.addChildren(ref this.btnConfig, 4, null);
        }

        private void bmiCadastroPessoaClick()
        {
            BaseLayout objParent = this.Parent as BaseLayout;
            BaseBody baseBody = null;
            foreach (object item in objParent.Children)
            {
                Type type = item.GetType();
                if (type.Name.Equals("BaseBody"))
                {
                    baseBody = item as BaseBody;
                    baseBody.Children.Clear();

                    CadastroPessoaView cpv = new CadastroPessoaView();
                    Grid.SetColumn(cpv, 1);
                    baseBody.Children.Add(cpv);
                    break;
                }
            }
        }

        private void bmiCadastroUsuarioClick()
        {
            BaseLayout objParent = this.Parent as BaseLayout;
            BaseBody baseBody = null;
            foreach (object item in objParent.Children)
            {
                Type type = item.GetType();
                if (type.Name.Equals("BaseBody"))
                {
                    baseBody = item as BaseBody;
                    baseBody.Children.Clear();

                    CadastroUsuarioView cuv = new CadastroUsuarioView();
                    Grid.SetColumn(cuv, 1);
                    baseBody.Children.Add(cuv);
                    break;
                }
            }
        }

        private void bmiCadastroClienteClick()
        {
            BaseLayout objParent = this.Parent as BaseLayout;
            BaseBody baseBody = null;
            foreach (object item in objParent.Children)
            {
                Type type = item.GetType();
                if (type.Name.Equals("BaseBody"))
                {
                    baseBody = item as BaseBody;
                    baseBody.Children.Clear();

                    CadastroPessoaView cpv = new CadastroPessoaView();
                    Grid.SetColumn(cpv, 1);
                    baseBody.Children.Add(cpv);
                    break;
                }
            }
        }

        private void bmiCadastroFornecedorClick()
        {
            BaseLayout objParent = this.Parent as BaseLayout;
            BaseBody baseBody = null;
            foreach (object item in objParent.Children)
            {
                Type type = item.GetType();
                if (type.Name.Equals("BaseBody"))
                {
                    baseBody = item as BaseBody;
                    baseBody.Children.Clear();

                    CadastroPessoaView cpv = new CadastroPessoaView();
                    Grid.SetColumn(cpv, 1);
                    baseBody.Children.Add(cpv);
                    break;
                }
            }
        }

        // Eventos

        private void btnCadastro_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.btnCadastro.Focus();
                this.loadBtnCadastroBCM();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnConsulta_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.btnConsulta.Focus();
                this.loadBtnConsultaBCM();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnConfig_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.btnConfig.Focus();
                this.loadBtnConfigBCM();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiCadastroPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                this.bmiCadastroPessoaClick();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiCadastroUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                this.bmiCadastroUsuarioClick();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiCadastroCliente_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Você clicou em 'Cadastro > Cliente'.", "Informação", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiCadastroFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Você clicou em 'Cadastro > Fornecedor'.", "Informação", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiConsultaPessoa_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Você clicou em 'Consulta > Pessoa'.", "Informação", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiConsultaProduto_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Você clicou em 'Consulta > Produto'.", "Informação", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiConsultaCaixa_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Você clicou em 'Consulta > Caixa'.", "Informação", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiConsultaPrateleira_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Você clicou em 'Consulta > Prateleira'.", "Informação", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiConsultaEstante_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Você clicou em 'Consulta > Estante'.", "Informação", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiConfigConexao_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Você clicou em 'Config > Conexão'.", "Informação", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void bmiConfigSobre_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Você clicou em 'Config > Sobre'.", "Informação", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}