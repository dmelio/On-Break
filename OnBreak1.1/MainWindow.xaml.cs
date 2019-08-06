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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using OnBreak.negocio;

namespace OnBreak1._1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static List<CoffeeBreak>coffees;
        public static List<Cenas>cenas;
        public static List<OnBreak.negocio.Cocktail> cocktails;

        private void BtnAdministrarClientes_Click(object sender, RoutedEventArgs e)
        {
            AdminClie cli = new AdminClie() { Owner = this };
            cli.ShowDialog();
        }

        private void BtnListaClientes_Click(object sender, RoutedEventArgs e)
        {
            ListaClientes list = new ListaClientes() { Owner = this };
            list.ShowDialog();
        }

        private void BtnAdministrarContratos_Click(object sender, RoutedEventArgs e)
        {
            AdminContratos cont = new AdminContratos() { Owner = this };
            cont.ShowDialog();
        }

        private void BtnListaContratos_Click(object sender, RoutedEventArgs e)
        {
            ListaContratos listc = new ListaContratos() { Owner = this };
            listc.ShowDialog();
        }

        private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
