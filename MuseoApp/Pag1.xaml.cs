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

namespace MuseoApp
{
    /// <summary>
    /// Logica di interazione per Pag1.xaml
    /// </summary>
    public partial class Pag1 : Window
    {
        public Pag1()
        {
            InitializeComponent();
        }

        private void btnCompra_Click(object sender, RoutedEventArgs e)
        {
            new MuseoAppPag0().ShowDialog();
        }

        private void btnPag_Click(object sender, RoutedEventArgs e)
        {
            new Pag2().ShowDialog();
        }
    }
}
