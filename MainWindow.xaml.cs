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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnOsszead_Click(object sender, RoutedEventArgs e)
        {
            String eredmemy = $"{txtAszam.Text} + {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) + Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye:" + eredmemy);
            lbEredmenyek.Items.Add(eredmemy);
        }

        private void btnKivon_Click(object sender, RoutedEventArgs e)
        {
            String eredmemy = $"{txtAszam.Text} - {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) - Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye:" + eredmemy);
            lbEredmenyek.Items.Add(eredmemy);
        }
        private void btnOsztas_Click(object sender, RoutedEventArgs e)
        {
            String eredmemy = $"{txtAszam.Text} / {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) / Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye:" + eredmemy);
            lbEredmenyek.Items.Add(eredmemy);
        }

        private void btnSzoroz_Click(object sender, RoutedEventArgs e)
        {
            String eredmemy = $"{txtAszam.Text} * {txtBszam.Text} = {Convert.ToDouble(txtAszam.Text) * Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye:" + eredmemy);
            lbEredmenyek.Items.Add(eredmemy);
        }
    }
}
