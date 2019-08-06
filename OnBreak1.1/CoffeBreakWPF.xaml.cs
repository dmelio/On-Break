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
    /// Lógica de interacción para CoffeBreakWPF.xaml
    /// </summary>
    public partial class CoffeBreakWPF : MetroWindow
    {
        public double ValorTotalEvento { get; set; }
        public CoffeBreakWPF()
        {
            InitializeComponent();
            CargarModalidad();
            CrearNumero();
            ValorTotalEvento = 0;
        }
         


        public void CargarModalidad()
        {
            int  tipo = 10;
            cbxModalidadCB.ItemsSource = new ModalidadServicio().ReadbyTipo(tipo);
            cbxModalidadCB.DisplayMemberPath = "Nombre";
            cbxModalidadCB.SelectedValuePath = "IdModalidad";
            cbxModalidadCB.SelectedIndex = 0;
        }
        public void CrearNumero()
        {
            string codigo = DateTime.Now.ToString("yyyyMMddHHmm");
            txtCodigo.Text = codigo;
        }

        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            total();
            MainWindow.coffees = new List<CoffeeBreak>();
            CoffeeBreak cb = new CoffeeBreak()
            {
                Numero = txtCodigo.Text,
                Vegetariana = (bool)ckbVegetariana.IsChecked,
                idModalidad = cbxModalidadCB.SelectedIndex,
                CantidadPersonal = int.Parse(txtPerAdd.Text),
                Asistentes = int.Parse(txtCantasis.Text),
                valortotal = txtTotalCB.Text
            };
            MainWindow.coffees.Add(cb);
           
        }

        private void CbxModalidadCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxModalidadCB.SelectedIndex == 0)
            {
                lblPersonalBase.Content = "2";
                lblValorBase.Content = "3";
            }
            if (cbxModalidadCB.SelectedIndex == 1)
            {
                lblPersonalBase.Content = "6";
                lblValorBase.Content = "8";
            }
            if (cbxModalidadCB.SelectedIndex == 2)
            {
                lblPersonalBase.Content = "6";
                lblValorBase.Content = "12";
            }
        }
        public void total()
        {
            if (cbxModalidadCB.SelectedIndex == 0)
            {
                CalculartotalLB();
            }
            if (cbxModalidadCB.SelectedIndex == 1)
            {
                calcularJournalBreak();
            }
            if (cbxModalidadCB.SelectedIndex == 2)
            {
                calcularDayBreak();
            }
        }
        private void CalculartotalLB()
        {
            double valorBase = (3 * 27765);
            double peradd = int.Parse(txtPerAdd.Text) - 4;
            double recargoperadd = 27765 / 2;
            if (int.Parse(txtCantasis.Text) >= 1 && int.Parse(txtCantasis.Text) <= 20)
            {

                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (peradd * recargoperadd);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (27765 * 3.5);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (27765 * 3);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (27765 * 2);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantasis.Text) >= 21 && int.Parse(txtCantasis.Text) <= 50)
            {
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (peradd * recargoperadd);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (27765 * 3.5);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (27765 * 3);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (27765 * 2);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantasis.Text) >= 51)
            {
                double add = ((int.Parse(txtCantasis.Text) - 50) / 20);
                double recargo = 2 * 27765;
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (add*recargo) + (peradd * recargoperadd);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3.5);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 2);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
            }
        }
        public void calcularJournalBreak()
        {
            double valorBase = (8 * 27765);
            double peradd = int.Parse(txtPerAdd.Text) - 4;
            double recargoperadd = 27765 / 2;
            if (int.Parse(txtCantasis.Text) >= 1 && int.Parse(txtCantasis.Text) <= 20)
            {
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (peradd * recargoperadd);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (27765 * 3.5);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (27765 * 3);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (27765 * 2);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantasis.Text) >= 21 && int.Parse(txtCantasis.Text) <= 50)
            {
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (peradd * recargoperadd);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (27765 * 3.5);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (27765 * 3);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (27765 * 2);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantasis.Text) >= 51)
            {
                double add = ((int.Parse(txtCantasis.Text) - 50) / 20);
                double recargo = 2 * 27765;
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (peradd * recargoperadd);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3.5);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 2);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
            }
        }
        public void calcularDayBreak()
        {
            double valorBase = (12 * 27765);
            double peradd = int.Parse(txtPerAdd.Text) - 4;
            double recargoperadd = 27765 / 2;
            if (int.Parse(txtCantasis.Text) >= 1 && int.Parse(txtCantasis.Text) <= 20)
            {
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (peradd * recargoperadd);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (27765 * 3.5);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (27765 * 3);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (27765 * 3) + (27765 * 2);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantasis.Text) >= 21 && int.Parse(txtCantasis.Text) <= 50)
            {
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (peradd * recargoperadd);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (27765 * 3.5);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (27765 * 3);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (27765 * 5) + (27765 * 2);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
            }
            if (int.Parse(txtCantasis.Text) >= 51)
            {
                double add = ((int.Parse(txtCantasis.Text) - 50) / 20);
                double recargo = 2 * 27765;
                if (int.Parse(txtPerAdd.Text) > 4)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (peradd * recargoperadd);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 4)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3.5);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) == 3)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 3);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
                if (int.Parse(txtPerAdd.Text) <= 2)
                {
                    ValorTotalEvento = valorBase + (add * recargo) + (27765 * 2);
                    txtTotalCB.Text = ValorTotalEvento.ToString();
                }
            }
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
