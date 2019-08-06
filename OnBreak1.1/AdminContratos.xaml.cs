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
    /// Lógica de interacción para AdminContratos.xaml
    /// </summary>
    public partial class AdminContratos : MetroWindow
    {
        
        
        public AdminContratos()
        {
            InitializeComponent();
            CargarTipoEvento();
            limpiar();
        }

        private void limpiar()
        {
            txtNumCont.Text = string.Empty;
            txtRutClie.Text = string.Empty;
            txtRazonSocial.Text = string.Empty;
            txtObs.Text = string.Empty;
            txtTotalPagar.Text = string.Empty;
            cbxTipoEvento.SelectedIndex = 0;
            cbxModalidad.SelectedIndex = 0;
            dpFechaCreacion1.SelectedDate = DateTime.Today;
            dpFechaTermino.SelectedDate = DateTime.Today;
            dpHoraIni.SelectedDate = DateTime.Today;
            dpHoraTer.SelectedDate = DateTime.Today;
            txtNumCont.IsEnabled = false;
            txtCantAsis.Text = string.Empty;
            txtPersonalAd.Text = string.Empty;
            CrearCodigo();
        }
       


        private void CargarModalidad()
        {
            int tipo =(int)cbxTipoEvento.SelectedIndex;
            if (cbxTipoEvento.SelectedIndex == 0)
            {
                cbxModalidad.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
                cbxModalidad.DisplayMemberPath = "Nombre";
                cbxModalidad.SelectedValuePath = "IdModalidad";
                cbxModalidad.SelectedIndex = 0;
            }
            if (cbxTipoEvento.SelectedIndex == 1)
            {
                tipo = 10;
                cbxModalidad.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
                cbxModalidad.DisplayMemberPath = "Nombre";
                cbxModalidad.SelectedValuePath = "IdModalidad";
                cbxModalidad.SelectedIndex = 0;
            }
            if (cbxTipoEvento.SelectedIndex == 2)
            {
                tipo = 20;
                cbxModalidad.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
                cbxModalidad.DisplayMemberPath = "Nombre";
                cbxModalidad.SelectedValuePath = "IdModalidad";
                cbxModalidad.SelectedIndex = 0;
            }
            if (cbxTipoEvento.SelectedIndex == 3)
            {
                tipo = 30;
                cbxModalidad.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
                cbxModalidad.DisplayMemberPath = "Nombre";
                cbxModalidad.SelectedValuePath = "IdModalidad";
                cbxModalidad.SelectedIndex = 0;
            }

        }

        private void CargarTipoEvento()
        {
            cbxTipoEvento.ItemsSource = new TipoEvento().ReadAll();
            cbxTipoEvento.DisplayMemberPath = "Descripcion";
            cbxTipoEvento.SelectedValuePath = "IdTipoEvento";
            cbxTipoEvento.SelectedIndex = 0;
        }


        private void BtnBuscarrut_Click(object sender, RoutedEventArgs e)
        {
            if (txtRutClie.Text == string.Empty)
            {
                ListaClientes list = new ListaClientes();
                list.ShowDialog();
            }
            else
            {
                Cliente clie = new Cliente()
                {
                    RutCliente = txtRutClie.Text
                };
                if (clie.Read())
                {
                    txtRutClie.Text = clie.RutCliente;
                    txtRazonSocial.Text = clie.RazonSocial;
                }
                else
                {
                    MessageBox.Show("Rut de cliente no existe :(", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }

        }

        private void BtnBuscarnum_Click(object sender, RoutedEventArgs e)
        {
            if (txtNumCont.IsEnabled == false)
            {
                txtNumCont.IsEnabled = true;
                txtNumCont.Text = string.Empty;
            }
            else
            {
                Contrato cont = new Contrato()
                {
                    Numero = txtNumCont.Text
                };
                if (cont.Read())
                {
                    txtNumCont.Text = cont.Numero;
                    txtRutClie.Text = cont.RutCliente;
                    
                    txtObs.Text = cont.Observaciones;
                    txtTotalPagar.Text = cont.ValorTotalContrato.ToString();
                    cbxTipoEvento.SelectedValue = cont.IdTipoEvento;
                    cbxModalidad.SelectedValue = cont.IdModalidad;
                    dpFechaCreacion1.SelectedDate = cont.Creacion;
                    dpFechaTermino.SelectedDate = cont.Termino;
                    dpHoraIni.SelectedDate = cont.FechaHoraInicio;
                    dpHoraTer.SelectedDate = cont.FechaHoraTermino;
                    txtCantAsis.Text = cont.Asistentes.ToString();
                    txtPersonalAd.Text = cont.PersonalAdicional.ToString();
                    checkVigencia.IsChecked = cont.Realizado;
                    Cliente clie = new Cliente()
                    {
                        RutCliente = txtRutClie.Text
                    };
                    if (clie.Read())
                    {
                        txtRazonSocial.Text = clie.NombreContacto;
                    }
                    txtNumCont.IsEnabled = false;
                }
                else
                {
                    MessageBox.Show("Contrato No Existe :(", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
        }


        private void BtnModificar_Click(object sender, RoutedEventArgs e)
        {
            if(ValidacionCont() == true)
            {
                MessageBox.Show("Todos los campos son obligatorios", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Contrato cont = new Contrato()
                {
                    Numero = txtNumCont.Text,
                    Creacion = (DateTime)dpFechaCreacion1.SelectedDate,
                    Termino = (DateTime)dpFechaTermino.SelectedDate,
                    RutCliente = txtRutClie.Text,
                    IdModalidad = cbxModalidad.SelectedValue.ToString(),
                    IdTipoEvento = (int)cbxTipoEvento.SelectedValue,
                    FechaHoraInicio = (DateTime)dpHoraIni.SelectedDate,
                    FechaHoraTermino = (DateTime)dpHoraTer.SelectedDate,
                    Asistentes = int.Parse(txtCantAsis.Text),
                    PersonalAdicional = int.Parse(txtPersonalAd.Text),
                    Realizado = (bool)checkVigencia.IsChecked,
                    ValorTotalContrato = double.Parse(txtTotalPagar.Text),
                    Observaciones = txtObs.Text
                };
                if (cont.Update())
                {
                    MessageBox.Show("Contrato modificado", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Contrato no pudo ser actualizado", "Atención", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            
        }


        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (dpFechaTermino.SelectedDate < DateTime.Today ||dpHoraTer.SelectedDate < DateTime.Today)
            {
                MessageBox.Show("La fecha de termino no púede ser menor a la de inicio", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (ValidacionCont() == true)
                {
                    MessageBox.Show("Todos los campos son obligatorios", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    Contrato cont = new Contrato()
                    {
                        Numero = txtNumCont.Text,
                        Creacion = (DateTime)dpFechaCreacion1.SelectedDate,
                        Termino = (DateTime)dpFechaTermino.SelectedDate,
                        RutCliente = txtRutClie.Text,
                        IdModalidad = cbxModalidad.SelectedValue.ToString(),
                        IdTipoEvento = (int)cbxTipoEvento.SelectedValue,
                        FechaHoraInicio = (DateTime)dpHoraIni.SelectedDate,
                        FechaHoraTermino = (DateTime)dpHoraTer.SelectedDate,
                        Asistentes = int.Parse(txtCantAsis.Text),
                        PersonalAdicional = int.Parse(txtPersonalAd.Text),
                        Realizado = (bool)checkVigencia.IsChecked,
                        ValorTotalContrato = double.Parse(txtTotalPagar.Text),
                        Observaciones = txtObs.Text
                    };
                    if (!cont.Read())
                    {
                        if (cont.Create())
                        {
                            MessageBox.Show("Contrato Registrado", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("Contrato No pudo ser registrado", "Atencion", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contrato Ya Existe", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

            }

        }

        private void BtnMenu_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
        public void CrearCodigo()
        {
            string codigo = DateTime.Now.ToString("yyyyMMddHHmm");
            txtNumCont.Text = codigo;
        }

        private void BtnListarCont_Click(object sender, RoutedEventArgs e)
        {
            ListaContratos listc = new ListaContratos();
            listc.ShowDialog();
        }

        private void CbxTipoEvento_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int tipo = (int)cbxTipoEvento.SelectedIndex;
            if (cbxTipoEvento.SelectedIndex == 0)
            {
                cbxModalidad.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
                cbxModalidad.DisplayMemberPath = "Nombre";
                cbxModalidad.SelectedValuePath = "IdModalidad";
                cbxModalidad.SelectedIndex = 0;
            }
            if (cbxTipoEvento.SelectedIndex == 1)
            {
                tipo = 10;
                cbxModalidad.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
                cbxModalidad.DisplayMemberPath = "Nombre";
                cbxModalidad.SelectedValuePath = "IdModalidad";
                cbxModalidad.SelectedIndex = 0;
                CoffeBreakWPF cb = new CoffeBreakWPF();
                cb.ShowDialog();
            }
            if (cbxTipoEvento.SelectedIndex == 3)
            {
                tipo = 30;
                cbxModalidad.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
                cbxModalidad.DisplayMemberPath = "Nombre";
                cbxModalidad.SelectedValuePath = "IdModalidad";
                cbxModalidad.SelectedIndex = 0;
                CenasWPF cena = new CenasWPF() { Owner = this };
                cena.ShowDialog();
            }
            if (cbxTipoEvento.SelectedIndex == 2)
            {
                tipo = 20;
                cbxModalidad.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
                cbxModalidad.DisplayMemberPath = "Nombre";
                cbxModalidad.SelectedValuePath = "IdModalidad";
                cbxModalidad.SelectedIndex = 0;
                Cocktail cock = new Cocktail() { Owner = this };
                cock.ShowDialog();
            }
        }

        private void BtnTerminar_Click(object sender, RoutedEventArgs e)
        {
            Contrato cont = new Contrato()
            {
                Numero = txtNumCont.Text
            };
            if (checkVigencia.IsChecked == true)
            {
                cont.Realizado = false;
            }
            else
            {
                MessageBox.Show("Contrato ya esta terminado", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }

        public bool ValidacionCont()
        {
            if (txtPersonalAd.Text == string.Empty||txtCantAsis.Text == string.Empty||txtRutClie.Text == string.Empty || txtRazonSocial.Text == string.Empty || txtObs.Text == string.Empty || cbxModalidad.SelectedIndex == 0 || cbxTipoEvento.SelectedIndex == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void BtnCalcular_Click(object sender, RoutedEventArgs e)
        {
            if(cbxTipoEvento.SelectedIndex == 1)
            {
                string coffelist = txtNumCont.Text;
                try
                {
                    foreach (CoffeeBreak cb in MainWindow.coffees)
                    {
                        if (cb.Numero == coffelist)
                        {
                            txtCantAsis.Text = cb.Asistentes.ToString();
                            txtPersonalAd.Text = cb.CantidadPersonal.ToString();
                            cbxModalidad.SelectedIndex = cb.idModalidad;
                            txtTotalPagar.Text = cb.valortotal;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            if (cbxTipoEvento.SelectedIndex == 2)
            {
                string cocktaillist = txtNumCont.Text;
                try
                {
                    foreach (OnBreak.negocio.Cocktail cb in MainWindow.cocktails)
                    {
                        if (cb.Numero == cocktaillist)
                        {
                            txtCantAsis.Text = cb.Asistentes.ToString();
                            txtPersonalAd.Text = cb.CantidadPersonal.ToString();
                            cbxModalidad.SelectedIndex = cb.idModalidad;
                            txtTotalPagar.Text = cb.valortotal;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                if (cbxTipoEvento.SelectedIndex == 3)
                {
                    string cenaslist = txtNumCont.Text;
                    try
                    {
                        foreach (Cenas cb in MainWindow.cenas)
                        {
                            if (cb.Numero == cenaslist)
                            {
                                txtCantAsis.Text = cb.Asistentes.ToString();
                                txtPersonalAd.Text = cb.CantidadPersonal.ToString();
                                cbxModalidad.SelectedIndex = cb.idModalidad;
                                txtTotalPagar.Text = cb.valortotal;
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}

        
 

    


      



