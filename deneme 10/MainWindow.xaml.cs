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

namespace deneme_10
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void lst_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lst.Items.Add(new { ADI = txt1.Text, SOYADI = txt3.Text, NUMARASI = (Convert.ToInt32(txt2.Text)) });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lst.Items.Remove(lst.SelectedItem);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lst.Items.Remove(lst.SelectedItem);
        }
    }
}

