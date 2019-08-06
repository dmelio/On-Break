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
    /// Lógica de interacción para ListaClientes.xaml
    /// </summary>
    public partial class ListaClientes : MetroWindow
    {
        public ListaClientes()
        {
            InitializeComponent();
            LLenardatagrid();
            CargarAct();
            CargarTipoEmpresa();
        }

        private void CargarAct()
        {
            cbxListAct.ItemsSource = new ActividadEmpresa().ReadAll();
            cbxListAct.DisplayMemberPath = "Descripcion";
            cbxListAct.SelectedValuePath = "IdActividadEmpresa";
            cbxListAct.SelectedIndex = 0;
        }

        private void CargarTipoEmpresa()
        {
            cbxlistTipoEmp.ItemsSource = new TipoEmpresa().ReadAll();
            cbxlistTipoEmp.DisplayMemberPath = "Descripcion";
            cbxlistTipoEmp.SelectedValuePath = "IdTipoEmpresa";
            cbxlistTipoEmp.SelectedIndex = 0;
        }

        public void LLenardatagrid()
        {
            Cliente clie = new Cliente();
            List<Cliente> ListCliente = clie.ReadAll();

            this.dtgClientes.ItemsSource = null;
            this.dtgClientes.ItemsSource = ListCliente;
        }

        public void setClienteObj(Cliente objClie)
        {
            
        }

        private void BtnQuitarfiltro_Click(object sender, RoutedEventArgs e)
        {
            Cliente clie = new Cliente();
            List<Cliente> ListCliente = clie.ReadAll();

            this.dtgClientes.ItemsSource = null;
            this.dtgClientes.ItemsSource = ListCliente;
            txtBuscador.Text = string.Empty;
            cbxlistTipoEmp.SelectedIndex = 0;
            cbxListAct.SelectedIndex = 0;
        }

        private void BtnBuscadorRut_Click(object sender, RoutedEventArgs e)
        {
            if (txtBuscador.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un rut :(", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Cliente clie = new Cliente()
                {
                    RutCliente = txtBuscador.Text
                };
                if (clie.Read())
                {
                    string rut = txtBuscador.Text;
                    dtgClientes.ItemsSource = new Cliente().ReadByRut(rut);
                }
                else
                {
                    MessageBox.Show("Rut ingresado no existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void BtnFiltrarporte_Click(object sender, RoutedEventArgs e)
        {
            int tipo = (int)cbxlistTipoEmp.SelectedValue;
            dtgClientes.ItemsSource = new Cliente().ReadByTipoEmp(tipo);
        }

        private void BtnFiltrarporAct_Click(object sender, RoutedEventArgs e)
        {
            int tipo = (int)cbxlistTipoEmp.SelectedValue;
            dtgClientes.ItemsSource = new Cliente().ReadByTipoEmp(tipo);
        }

        private void Btnmenuprinc_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
  
}
