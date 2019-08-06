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
    /// Lógica de interacción para CenasWPF.xaml
    /// </summary>
    public partial class CenasWPF : MetroWindow
    {
        public CenasWPF()
        {
            InitializeComponent();
            ValorTotalEvento = 0;
            CargarModalidad();
            CrearNumero();
            cargarAmbientacion();
        }
        public double ValorTotalEvento { get; set; }
      
        public void CargarModalidad()
        {
            int tipo = 30;
            cbxModalidadCena.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
            cbxModalidadCena.DisplayMemberPath = "Nombre";
            cbxModalidadCena.SelectedValuePath = "IdModalidad";
            cbxModalidadCena.SelectedIndex = 0;
        }
        public void cargarAmbientacion()
        {
            cbxAmbientacion.ItemsSource = new TipoAmbientacion().ReadAll();
            cbxAmbientacion.DisplayMemberPath = "Descripcion";
            cbxAmbientacion.SelectedValuePath = "IdTipoAmbientacion";
            cbxAmbientacion.SelectedIndex = 0;
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            total();
            MainWindow.cenas = new List<Cenas>();
            Cenas c = new Cenas()
            {
               Numero = txtNumero.Text.ToString(),
               IdTipoAmbientacion = cbxAmbientacion.SelectedIndex,
               MusicaAmbiental = (bool)chkMusica.IsChecked,
               LocalOnBreak = (bool)chkLocal.IsChecked,
               ValorArriendo = int.Parse(txtValorarriendo.Text),
                idModalidad = cbxModalidadCena.SelectedIndex,
                CantidadPersonal = int.Parse(txtPerAdd.Text),
                Asistentes = int.Parse(txtCantAsis.Text),
                valortotal = txtTotal.Text
            };
            MainWindow.cenas.Add(c);
            Hide();
        }

        private void CbxModalidadCena_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxModalidadCena.SelectedIndex == 0)
            {
                lblPersonalBase.Content = "10";
                lblValorBase.Content = "25";
            }
            if (cbxModalidadCena.SelectedIndex == 1)
            {
                lblPersonalBase.Content = "14";
                lblValorBase.Content = "35";
            }
        }
        public void total()
        {
            if (cbxModalidadCena.SelectedIndex == 0)
            {
                calcularEjecutiva();
            }
            if (cbxModalidadCena.SelectedIndex == 1)
            {
                calcularCelebración();
            }

        }
        public void calcularEjecutiva()
        {
            double valorBase = (25 * 27765);
            double peradd = int.Parse(txtPerAdd.Text) - 4;
            double recargoperadd = 27765 / 2;

            if (int.Parse(txtCantAsis.Text) >= 1 && int.Parse(txtCantAsis.Text) <= 20)
            {
                double totalsis = (27765 * 1.5);
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (peradd * recargoperadd);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3.5);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 2);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantAsis.Text) >= 21 && int.Parse(txtCantAsis.Text) <= 50)
            {
                double totalsis = (27765 * 1.2);
                if (int.Parse(txtPerAdd.Text) >= 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (peradd * recargoperadd);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3.5);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 2);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantAsis.Text) >= 51)
            {
                double add = ((int.Parse(txtCantAsis.Text) - 50) / 20);
                double recargo = 2 * 27765;
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (peradd * recargoperadd);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3.5);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 2);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
            }
        }
        public void calcularCelebración()
        {
            double valorBase = (35 * 27765);
            double peradd = int.Parse(txtPerAdd.Text) - 4;
            double recargoperadd = 27765 / 2;
            if (int.Parse(txtCantAsis.Text) >= 1 && int.Parse(txtCantAsis.Text) <= 20)
            {
                double totalsis = (27765 * 1.5);
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (peradd * recargoperadd);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3.5);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 2);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantAsis.Text) >= 21 && int.Parse(txtCantAsis.Text) <= 50)
            {
                double totalsis = (27765 * 1.2);
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (peradd * recargoperadd);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3.5);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 3);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + totalsis + (27765 * 2);
                    txtTotal.Text = ValorTotalEvento.ToString();
                }
            }
        }


        public void CrearNumero()
        {
            string codigo = DateTime.Now.ToString("yyyyMMddHHmm");
            txtNumero.Text = codigo;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
