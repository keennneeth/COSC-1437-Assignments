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

namespace WPF_Application
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

            var aStringWithCharacters = "123x";
            var theIntegerValueOfTheString = Convert.ToInt32(aStringWithCharacters);
            MessageBox.Show("This point cannot be reached.");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var aStringWithCharacters = "123.4";
            var theIntegerValueOfTheString = Convert.ToInt32(aStringWithCharacters);
            MessageBox.Show("This point cannot be reached.");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var aStringWithCharacters = "5000000000"; //5 Billion
            var theIntegerValueOfTheString = Convert.ToInt32(aStringWithCharacters);
            MessageBox.Show("This point cannot be reached.");
        }
    }
}
