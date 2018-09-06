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

namespace Dojo
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


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            submit.Visibility = Visibility.Visible;
            input.Visibility = Visibility.Visible;
            start.Visibility = Visibility.Hidden;
        }

        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
            submit.Visibility = Visibility.Hidden;
            input.Visibility = Visibility.Hidden;
        }
    }
}
