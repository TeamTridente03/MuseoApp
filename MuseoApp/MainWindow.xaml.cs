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

namespace MuseoApp
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnAccedi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string email;
                string password;

                if (txtEmail.Text != "")
                {
                    email = txtEmail.Text;
                }
                else throw new Exception(" Immettere una EMAIL");

                if (txtPass.Text != "")
                {
                    password = txtPass.Text;
                }
                else throw new Exception(" Immettere una PASSWORD");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            new Pag1().ShowDialog();
            

        }
    }
}
