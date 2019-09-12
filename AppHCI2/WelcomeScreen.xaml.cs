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
using System.Threading;
using System.Windows.Threading;

namespace AppHCI2
{
    /// <summary>
    /// Interaction logic for WelcomeScreen.xaml
    /// </summary>
    public partial class WelcomeScreen : Window
    {
        Thread MemuatThread;
        public WelcomeScreen()
        {
            InitializeComponent();
        }
        private void MemuatJendela(object sender, RoutedEventArgs e)
        {
            MemuatThread = new Thread(Load);
            MemuatThread.Start();
        }
        private void Load()
        {
            Thread.Sleep(1500);
            this.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)delegate() { Close(); });
        }
    }
}
