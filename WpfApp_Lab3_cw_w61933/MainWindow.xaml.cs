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

namespace WpfApp_Lab3_cw_w61933
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            double x = Convert.ToDouble(tbX.Text);
            double y = Convert.ToDouble(tbY.Text);
            tbWynik.Visibility = Visibility.Visible;
            tbWynik.Text = tbX.Text+ " + " + tbY.Text + " = " + Convert.ToString(x + y);

        }

        private void bRoznica_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(tbX.Text);
            double y = Convert.ToDouble(tbY.Text);
            tbWynik.Visibility = Visibility.Visible;
            tbWynik.Text = tbX.Text + " - " + tbY.Text + " = " + Convert.ToString(x - y);
        }

        private void bIloczyn_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(tbX.Text);
            double y = Convert.ToDouble(tbY.Text);
            tbWynik.Visibility = Visibility.Visible;
            tbWynik.Text = tbX.Text + " * " + tbY.Text + " = " + Convert.ToString(x * y);
        }

        private void bIloraz_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(tbX.Text);
            double y = Convert.ToDouble(tbY.Text);
            tbWynik.Visibility = Visibility.Visible;
            if (y != 0)
            { 
                tbWynik.Text = tbX.Text + " / " + tbY.Text + " = " + Convert.ToString(x / y);
            }
            else
            {
                tbWynik.Text = "Nie dziel przez 0";
            }

        }
    }
}
