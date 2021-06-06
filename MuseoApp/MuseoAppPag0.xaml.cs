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
    /// Logica di interazione per MuseoAppPag0.xaml
    /// </summary>
    public partial class MuseoAppPag0 : Window
    {
        public MuseoAppPag0()
        {
            InitializeComponent();

          
        }

        private void btnCompra_Click(object sender, RoutedEventArgs e)
        {

            double Quantita = double.Parse(txtQuantita.Text);
            int prezzo = 15;
            double totale = Quantita * prezzo;
            lblReso.Content = $"{totale}";
            
        }
    }
}
