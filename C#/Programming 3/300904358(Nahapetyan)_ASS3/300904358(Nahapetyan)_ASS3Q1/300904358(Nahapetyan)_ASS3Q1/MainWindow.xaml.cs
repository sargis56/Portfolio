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

namespace _300904358_Nahapetyan__ASS3Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //loginControl.Password = "test";

            testUserNameResult.Content = loginControl.UserName;
            testPasswordResult.Content = loginControl.Password;
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {         
            if (loginControl.CheckLogin())
            {
                MessageBox.Show("Login successful");
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }
    }
}
