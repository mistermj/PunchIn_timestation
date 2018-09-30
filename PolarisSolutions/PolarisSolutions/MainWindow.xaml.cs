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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PolarisSolutions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void punchIn_Click(object sender, RoutedEventArgs e)
        {
            if (Foundation.IsEmpty(username.Text, password.Password))
            {
                Foundation.ShowStatusMessage("ERROR: No Custom Username/Email Or Password Provided");
                Application.Current.Shutdown();
            }
            Foundation.CustomPunchIn(username.Text, password.Password);
            Foundation.ShowStatusMessage("Action Performed Successfully!");
        }

        private void punchOut_Click(object sender, RoutedEventArgs e)
        {
            if (Foundation.IsEmpty(username.Text, password.Password))
            {
                Foundation.ShowStatusMessage("ERROR: No Custom Username/Email Or Password Provided");
                Application.Current.Shutdown();
            }
            Foundation.CustomPunchIn(username.Text, password.Password);

            Foundation.ShowStatusMessage("Action Performed Successfully!");
        }

        private void LoadAndPunchIn_Click(object sender, RoutedEventArgs e)
        {
            Foundation.LoadCredentials();   
        }
    }
}
