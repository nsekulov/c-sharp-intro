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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFhello
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

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result =
              MessageBox.Show(
                "🔫 Are you sure about that?",
                "Data App",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    s += ((TextBox)item).Text;
                    s += '\n';
                }
            }
            if (txtName.Text.Length <= 2)
            {
                MessageBox.Show("Minimum lenght of 2 characters.");
            }
            else
            {
                MessageBox.Show("Здрасти " + s + "!!! \nТова е твоята първа програма на VisualStudio 2023!");
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
