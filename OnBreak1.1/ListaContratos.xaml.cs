using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para ListaContratos.xaml
    /// </summary>
    public partial class ListaContratos : MetroWindow
    {
        public ListaContratos()
        {
            InitializeComponent();
            CargarContratos();
            CargarModalidad();
            CargarTipoEvento();
        }

        private void BtnAtras_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        private void CargarContratos()
        {
            Contrato cont = new Contrato();
            List<Contrato> ListContrato = cont.ReadAll();

            this.dtgContratos.ItemsSource = null;
            this.dtgContratos.ItemsSource = ListContrato;
        }

        private void CargarModalidad()
        {
            cbxMod.ItemsSource = new ModalidadServicio().ReadAll();
            cbxMod.DisplayMemberPath = "Nombre";
            cbxMod.SelectedValuePath = "IdModalidad";
            cbxMod.SelectedIndex = 0;
        }

        private void CargarTipoEvento()
        {
            cbxTipEve.ItemsSource = new TipoEvento().ReadAll();
            cbxTipEve.DisplayMemberPath = "Descripcion";
            cbxTipEve.SelectedValuePath = "IdTipoEvento";
            cbxTipEve.SelectedIndex = 0;
        }

        private void BtnBuscNumcont_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumCont.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un numero de contrato :(", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Contrato cont = new Contrato()
                {
                    Numero = txtNumCont.Text
                };
                if (cont.Read())
                {
                    string num = txtNumCont.Text;
                    dtgContratos.ItemsSource = new Contrato().ReadByNumCont(num);
                }
                else
                {
                    MessageBox.Show("Numero de contrato no existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void BtnBuscRut_Click(object sender, RoutedEventArgs e)
        {
            if (txtRutClie.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un rut :(", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Cliente cont = new Cliente()
                {
                    RutCliente = txtRutClie.Text
                };
                if (cont.Read())
                {
                    string rut = txtRutClie.Text;
                    dtgContratos.ItemsSource = new Contrato().ReadByRutclie(rut);
                }
                else
                {
                    MessageBox.Show("Rut ingresado no existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
  
        private void BtnBusctipoe_Click(object sender, RoutedEventArgs e)
        {
            int tipoE = (int)cbxTipEve.SelectedValue;
            dtgContratos.ItemsSource = new Contrato().ReadByTipoEve(tipoE);
        }

        private void BtnBuscMod_Click(object sender, RoutedEventArgs e)
        {
            string Mod = cbxMod.SelectedValue.ToString();
            dtgContratos.ItemsSource = new Contrato().ReadByMod(Mod);
        }

        private void BtnQuitarfiltro_Click(object sender, RoutedEventArgs e)
        {
            Contrato cont = new Contrato();
            List<Contrato> ListContrato = cont.ReadAll();

            this.dtgContratos.ItemsSource = null;
            this.dtgContratos.ItemsSource = ListContrato;
            cbxMod.SelectedIndex = 0;
            cbxTipEve.SelectedIndex = 0;
            txtNumCont.Text = string.Empty;
            txtRutClie.Text = string.Empty;
        }

        private void BtnAtras_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
