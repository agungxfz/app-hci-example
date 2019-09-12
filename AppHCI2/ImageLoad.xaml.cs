using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppHCI2
{
    /// <summary>
    /// Interaction logic for ImageLoad.xaml
    /// </summary>
    public partial class ImageLoad : Window
    {
        public ImageLoad()
        {
            InitializeComponent();
        }
        private void keluar_wnd(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
