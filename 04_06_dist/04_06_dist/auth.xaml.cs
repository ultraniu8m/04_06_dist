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

namespace _04_06_dist
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        public auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox.IsChecked.Value)
            {
                visible_pass.Text = password_.Password;
                password_.Visibility = Visibility.Hidden;
                visible_pass.Visibility = Visibility.Visible;

            }
            else
            {
                password_.Password = visible_pass.Text;
                visible_pass.Visibility = Visibility.Hidden;
                password_.Visibility = Visibility.Visible;
            }
                

        }
    }
}
