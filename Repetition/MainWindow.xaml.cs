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

namespace Repetition
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

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "FRANKRIKE";

        }

      
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text.Text = "SVERIGE";
        }

      
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text.Text = "TYSKLAND";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (text.Text == "")
            {
                Console.WriteLine("NOTHING TO REMOVE");
            }
            else
            {
                text.Text = "";
            }

        }
    }
}
