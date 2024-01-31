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
using System.Windows.Shapes;

namespace Variant_2_Kontrol_Work
{
    /// <summary>
    /// Логика взаимодействия для Uchetka.xaml
    /// </summary>
    public partial class Uchetka : Window
    {
        public Uchetka()
        {
            InitializeComponent();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Maneger main = new Maneger();
            main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
