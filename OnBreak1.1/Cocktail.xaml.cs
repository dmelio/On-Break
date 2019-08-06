using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using OnBreak.negocio;

namespace OnBreak1._1
{
    /// <summary>
    /// Lógica de interacción para Cocktail.xaml
    /// </summary>
    public partial class Cocktail : MetroWindow
    {
        public double ValorTotalEvento { get; set; }
        public Cocktail()
        {
            InitializeComponent();
            ValorTotalEvento = 0;
            CargarModalidad();
            cargarAmbientacion();
            CrearNumero();
        }

        public void CargarModalidad()
        {
            int tipo = 20;
            cbxMod.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
            cbxMod.DisplayMemberPath = "Nombre";
            cbxMod.SelectedValuePath = "IdModalidad";
            cbxMod.SelectedIndex = 0;
        }
        public void cargarAmbientacion()
        {
            cbxAmbient.ItemsSource = new TipoAmbientacion().ReadAll();
            cbxAmbient.DisplayMemberPath = "Descripcion";
            cbxAmbient.SelectedValuePath = "IdTipoAmbientacion";
            cbxAmbient.SelectedIndex = 0;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void CbxMod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxMod.SelectedIndex == 0)
            {
                lblPersonalBase.Content = "4";
                lblValorBase.Content = "6";
            }
            if (cbxMod.SelectedIndex == 1)
            {
                lblPersonalBase.Content = "5";
                lblValorBase.Content = "10";
            }
        }
        public void CrearNumero()
        {
            string codigo = DateTime.Now.ToString("yyyyMMddHHmm");
            txtNumero.Text = codigo;
        }

        public void calcularQuickCocktail()
        {
            double valorBase = (6 * 27765);
            double peradd = int.Parse(txtPerAdd.Text) - 4;
            double recargoperadd = 27765 / 2;

            if (int.Parse(txtCantAsis.Text) >= 1 && int.Parse(txtCantAsis.Text) <= 20)
            {
                double totalsis = (27765 * 1.5);
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (peradd * recargoperadd);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3.5);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 2);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantAsis.Text) >= 21 && int.Parse(txtCantAsis.Text) <= 50)
            {
                double totalsis = (27765 * 1.2);
                if (int.Parse(txtPerAdd.Text) >= 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (peradd * recargoperadd);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3.5);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 2);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantAsis.Text) >= 51)
            {
                double add = ((int.Parse(txtCantAsis.Text) - 50) / 20);
                double recargo = 2 * 27765;
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (peradd * recargoperadd);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3.5);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 2);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
            }
        }
        public void calcularAmbientCocktail()
        {
            double valorBase = (10 * 27765);
            double peradd = int.Parse(txtPerAdd.Text) - 4;
            double recargoperadd = 27765 / 2;
            if (int.Parse(txtCantAsis.Text) >= 1 && int.Parse(txtCantAsis.Text) <= 20)
            {
                double totalsis = (27765 * 1.5);
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (peradd * recargoperadd);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3.5);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 2);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantAsis.Text) >= 21 && int.Parse(txtCantAsis.Text) <= 50)
            {
                double totalsis = (27765 * 1.2);
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (peradd * recargoperadd);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3.5);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 2);
                    txttotal.Text = ValorTotalEvento.ToString();
                }
            }
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            total();
            MainWindow.cocktails = new List<OnBreak.negocio.Cocktail>();
            OnBreak.negocio.Cocktail c = new OnBreak.negocio.Cocktail()
            {
               Numero = txtNumero.Text,
               IdTipoAmbientacion = cbxAmbient.SelectedIndex,
               MusicaAmbiental = (bool)rbMusicaAmb.IsChecked,
               MusicaCliente = (bool)rbMusicaClie.IsChecked,
               idModalidad = cbxMod.SelectedIndex,
                CantidadPersonal = int.Parse(txtPerAdd.Text),
                Asistentes = int.Parse(txtCantAsis.Text),
                valortotal = txttotal.Text
            };
            MainWindow.cocktails.Add(c);
            Hide();
        }

        public void total()
        {
            if (cbxMod.SelectedIndex == 1)
            {
                calcularAmbientCocktail();
            }
            if (cbxMod.SelectedIndex == 0)
            {
                calcularQuickCocktail();
            }

        }
    }
}
