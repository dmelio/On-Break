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
    /// Lógica de interacción para AdminClie.xaml
    /// </summary>
    public partial class AdminClie : MetroWindow
    {
        public AdminClie()
        {
            InitializeComponent();
            limpiar();
        }
        private void limpiar()
        {
            txtRut.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbxActividad.SelectedIndex = 0;
            cbxTipoemp.SelectedIndex = 0;
            CargarTipoEmpresa();
            CargarAct();
        }

        private void CargarAct()
        {
            cbxActividad.ItemsSource = new ActividadEmpresa().ReadAll();
            cbxActividad.DisplayMemberPath = "Descripcion";
            cbxActividad.SelectedValuePath = "IdActividadEmpresa";
            cbxActividad.SelectedIndex = 0;
        }

        private void CargarTipoEmpresa()
        {
            cbxTipoemp.ItemsSource = new TipoEmpresa().ReadAll();
            cbxTipoemp.DisplayMemberPath = "Descripcion";
            cbxTipoemp.SelectedValuePath = "IdTipoEmpresa";
            cbxTipoemp.SelectedIndex = 0;
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (Validacion() == true)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Cliente clie = new Cliente()
                {
                    RutCliente = txtRut.Text,
                    RazonSocial = txtRazonSocial.Text,
                    NombreContacto = txtNombre.Text,
                    MailContacto = txtMail.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    IdActividadEmpresa = (int)cbxActividad.SelectedValue,
                    IdTipoEmpresa = (int)cbxTipoemp.SelectedValue
                };
                if (!clie.Read())
                {
                    if (clie.Create())
                    {
                        MessageBox.Show("Cliente Registrado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no pudo ser registrado", "Atención", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Cliente ya Existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }    
        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }

        private void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (txtRut.Text == string.Empty)
            {
                ListaClientes list = new ListaClientes();
                list.Show();
            }
            else
            {
                Cliente clie = new Cliente()
                {
                    RutCliente = txtRut.Text
                };
                if (clie.Read())
                {
                    txtRut.Text = clie.RutCliente;
                    txtNombre.Text = clie.NombreContacto;
                    txtDireccion.Text = clie.Direccion;
                    txtMail.Text = clie.MailContacto;
                    txtRazonSocial.Text = clie.RazonSocial;
                    txtTelefono.Text = clie.Telefono;
                    cbxActividad.SelectedValue = clie.IdActividadEmpresa;
                    cbxTipoemp.SelectedValue = clie.IdTipoEmpresa;
                }
                else
                {
                    MessageBox.Show("Rut de cliente no existe :(", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
         
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if(txtRut.Text == string.Empty)
            {
                MessageBox.Show("Ingrese rut valido", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Contrato cont = new Contrato()
                {
                    RutCliente = txtRut.Text
                };
                string rut = txtRut.Text;
                if (cont.Read())
                {
                    Cliente clie = new Cliente()
                    {
                        RutCliente = txtRut.Text
                    };
                    MessageBoxResult eliminar = MessageBox.Show("¿Esta seguro de eliminar este cliente?", "Confirmar", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (eliminar == MessageBoxResult.Yes)
                    {
                        if (clie.Delete())
                        {
                            MessageBox.Show("Cliente eliminado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                            limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente no pudo ser eliminado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden eliminar clientes con contratos asociados", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }

        }

        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (Validacion() == true)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Cliente clie = new Cliente()
                {
                    RutCliente = txtRut.Text,
                    RazonSocial = txtRazonSocial.Text,
                    NombreContacto = txtNombre.Text,
                    MailContacto = txtMail.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    IdActividadEmpresa = (int)cbxActividad.SelectedValue,
                    IdTipoEmpresa = (int)cbxTipoemp.SelectedValue
                };
                if (clie.Update())
                {
                    MessageBox.Show("Cliente modificado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Cliente no pudo ser actualizado", "Atención", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }

        }

        public bool Validacion()
        {
            if(txtRut.Text == string.Empty || txtNombre.Text == string.Empty || txtRazonSocial.Text == string.Empty || txtMail.Text == string.Empty || txtDireccion.Text == string.Empty || txtTelefono.Text == string.Empty)
            {
                return true;
                
            }
            else
            {
                return false;
            }
            
        }
    }
            
}
