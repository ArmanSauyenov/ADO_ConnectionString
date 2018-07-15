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

namespace DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string s;
        public static int v;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChoiceVariant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            v = ChoiceVariant_.SelectedIndex;
            // v = ((ComboBoxItem)(ChoiceVariant.SelectionBoxItem)).Content.ToString();
        }

        private void ButtonConnect_Click(object sender, RoutedEventArgs e)
        {
            s = ConnectionString_.Text;

            try
            {
                if (v == 0)
                {
                    Frame_.Source = new Uri("Pages/SqlC.xaml", UriKind.RelativeOrAbsolute);
                }
                else if (v == 1)
                {
                    Frame_.Source = new Uri("Pages/ODB.xaml", UriKind.RelativeOrAbsolute);
                }
                else if (v == 2)
                {
                    Frame_.Source = new Uri("Pages/OD.xaml", UriKind.RelativeOrAbsolute);
                }
                else
                {
                    MessageBox.Show("Something went wrong...  ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
