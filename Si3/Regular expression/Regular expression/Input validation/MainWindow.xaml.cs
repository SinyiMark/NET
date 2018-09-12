using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Input_validation
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
            if (!Regex.IsMatch(txtName.Text, @"^([A-Za-z]+\s*)+$"))
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            string pattern = @"_^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$_";
            Console.WriteLine(Regex.Replace(txtPhone.Text, pattern, @"$1-$2-$3"));
        }
    }
}
