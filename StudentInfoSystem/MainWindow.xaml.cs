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

namespace StudentInfoSystem
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

        private void ClearFields_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in StudentInfoGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }

        }

        private void AutoFill_Click(object sender, RoutedEventArgs e)
        {
            Student student = StudentData.students.First();
            foreach (var item in StudentInfoGrid.Children)
            {
                if (item is TextBox)
                {
                    TextBox curr_item = ((TextBox)item);
                    switch (curr_item.Name)
                    {
                        case "StudentFaculty":
                            curr_item.Text = student.Faculty;
                            break;
                        case "StudentSpecialty":
                            curr_item.Text = student.Specialty;
                            break;
                        case "StudentFacNumber":
                            curr_item.Text = student.Faculty_ID;
                            break;
                        default:
                            break;
                    }

                }
            }
        }

        private void DisableAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in StudentInfoGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }

        private void EnableAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in StudentInfoGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in InfoGrid.Children)
            {
                if (item is GroupBox)
                { 
                    ((GroupBox)item).Visibility = Visibility.Visible;
                }
                if (item is Button)
                {
                    Button btn = (Button)item;
                    switch (btn.Name)
                    {
                        case "LogOut":
                           ((Button)item).Visibility = Visibility.Visible;
                            break;
                        case "LogIn":
                            ((Button)item).Visibility = Visibility.Hidden;
                            break;
                    }
                }
            }
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in InfoGrid.Children)
            {
                if (item is GroupBox)
                {
                    ((GroupBox)item).Visibility = Visibility.Hidden;
                }
                if (item is Button)
                {
                    Button btn = (Button)item;
                    switch (btn.Name)
                    {
                        case "LogOut":
                            ((Button)item).Visibility = Visibility.Hidden;
                            break;
                        case "LogIn":
                            ((Button)item).Visibility = Visibility.Visible;
                            break;
                    }
                }
            }
        }
    }
}
