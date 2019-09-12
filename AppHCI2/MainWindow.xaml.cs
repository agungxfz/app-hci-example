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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppHCI2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int flag = 0;

        public MainWindow()
        {
            InitializeComponent();
            new WelcomeScreen().ShowDialog();
        }

        private void MainMusik(object sender, RoutedEventArgs e)
        {
            MediaX.Source = new Uri("C:\\musik.mp3");
            MediaX.Play();
        }
        private void Mainkan()
        {
            MediaX.Source = new Uri("C:\\musik.mp3");
            MediaX.Play();
        }
        private void MainLagi(object sender, RoutedEventArgs e)
        {
            Mainkan();
        }
        private void A_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0) 
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/ayam.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("A");
                ImL.NamaBelakang.Content = String.Format("YAM");
                ImL.lblExplain.Text = String.Format("Ayam adalah hewan unggas yang tidak bisa terbang, dan biasa dipelihara orang untuk dimanfaatkan untuk daging dan telurnya. Ayam tergolong hewan pemakan biji.");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/anjing.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("A");
                ImL.NamaBelakang.Content = String.Format("NJING");
                ImL.lblExplain.Text = String.Format("Anjing adalah hewan berkaki empat yang sering dipelihara manusia, bisa dilatih dan biasa digunakan oleh pihak polisi untuk keperluan penyelidikan. Anjing tergolong hewan pemakan daging");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/aligator.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("A");
                ImL.NamaBelakang.Content = String.Format("LIGATOR");
                ImL.lblExplain.Text = String.Format("Aligator adalah hewan yang masih berkerabat dekat dengan buaya. Aligator hidup di air tawar atau di rawa - rawa. Aligator tergolong hewan pemakan daging");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
            
        }
        private void B_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/badak.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("B");
                ImL.NamaBelakang.Content = String.Format("ADAK");
                ImL.lblExplain.Text = String.Format("Badak adalah hewan berkaki empat yang memiliki kulit tebal dan keras juga memiliki cula dihidungnya, Badak hidup dipulau Jawa dan Sumatera. badak tergolong hewan pemakan tumbuhan");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/bekantan.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("B");
                ImL.NamaBelakang.Content = String.Format("EKANTAN");
                ImL.lblExplain.Text = String.Format("Bekantan adalah adalah sejenis monyet berhidung panjang dengan rambut berwarna coklat kemerahan. Bekantan tersebar dan endemik di hutan bakau, rawa dan hutan pantai di pulau Borneo (Kalimantan, Sabah, Serawak dan Brunai). Bekantan tergolong hewan pemakan tumbuhan.");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/babi.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("B");
                ImL.NamaBelakang.Content = String.Format("ABI");
                ImL.lblExplain.Text = string.Format("Babi adalah hewan yang bermoncong panjang dan berhidung lemper dan merupakan hewan yang aslinya berasal dari Eurasia. Babi adalah omnivora, yang berarti mereka mengonsumsi baik daging maupun tumbuh-tumbuhan.");
                Nullable<bool> windowMdl = ImL.ShowDialog();
            }
            
        }
        private void C_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/cicak.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("C");
                ImL.NamaBelakang.Content = String.Format("ICAK");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/capung.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("C");
                ImL.NamaBelakang.Content = String.Format("APUNG");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/cacing.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("C");
                ImL.NamaBelakang.Content = String.Format("ACING");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
            
        }
        private void D_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/domba.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("D");
                ImL.NamaBelakang.Content = String.Format("OMBA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/dara.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("D");
                ImL.NamaBelakang.Content = String.Format("ARA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/duyung.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("D");
                ImL.NamaBelakang.Content = String.Format("UYUNG");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
            
        }
        private void E_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/elang.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("E");
                ImL.NamaBelakang.Content = String.Format("LANG");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/elang.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("E");
                ImL.NamaBelakang.Content = String.Format("LANG");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/elang.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("E");
                ImL.NamaBelakang.Content = String.Format("LANG");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
            
        }
        private void F_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/flamingo.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("F");
                ImL.NamaBelakang.Content = String.Format("LAMINGO");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/flamingo.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("F");
                ImL.NamaBelakang.Content = String.Format("LAMINGO");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/flamingo.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("F");
                ImL.NamaBelakang.Content = String.Format("LAMINGO");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
            
        }
        private void G_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/gajah.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("G");
                ImL.NamaBelakang.Content = String.Format("AJAH");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/gorila.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("G");
                ImL.NamaBelakang.Content = String.Format("ORILA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/gurame.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("G");
                ImL.NamaBelakang.Content = String.Format("URAME");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void H_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/harimau.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("H");
                ImL.NamaBelakang.Content = String.Format("ARIMAU");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/harimau.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("H");
                ImL.NamaBelakang.Content = String.Format("ARIMAU");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/harimau.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("H");
                ImL.NamaBelakang.Content = String.Format("ARIMAU");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void I_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/ikan.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("I");
                ImL.NamaBelakang.Content = String.Format("KAN");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/ikan.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("I");
                ImL.NamaBelakang.Content = String.Format("KAN");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/ikan.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("I");
                ImL.NamaBelakang.Content = String.Format("KAN");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void J_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/jerapah.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("JERAPAH");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/jerapah.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("JERAPAH");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/jerapah.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("JERAPAH");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void K_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/kuda.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("KUDA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/kuda.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("KUDA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/kuda.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("KUDA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void L_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/laba-laba.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("LABA - LABA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/laba-laba.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("LABA - LABA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/laba-laba.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("LABA - LABA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void M_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/monyet.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("MONYET");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/monyet.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("MONYET");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/monyet.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("MONYET");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void N_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/nyamuk.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("NYAMUK");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/nyamuk.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("NYAMUK");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/nyamuk.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("NYAMUK");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void O_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/orang-utan.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("ORANG UTAN");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/orang-utan.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("ORANG UTAN");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/orang-utan.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("ORANG UTAN");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void P_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/panda.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("PANDA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/panda.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("PANDA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/panda.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("PANDA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void Q_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/quetzal.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("QUETZAL");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/quetzal.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("QUETZAL");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/quetzal.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("QUETZAL");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void R_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/rusa.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("RUSA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/rusa.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("RUSA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/rusa.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("RUSA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void S_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/semut.jpeg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("SEMUT");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/semut.jpeg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("SEMUT");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/semut.jpeg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("SEMUT");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void T_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/trenggiling.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("TRENGGILING");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/trenggiling.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("TRENGGILING");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/trenggiling.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("TRENGGILING");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void U_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/ular.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("ULAR");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/ular.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("ULAR");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/ular.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("ULAR");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void V_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/vulture.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("VULTURE");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/vulture.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("VULTURE");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/vulture.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("VULTURE");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void W_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/walrus.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("WALRUS");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/walrus.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("WALRUS");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/walrus.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("WALRUS");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
            
        }
        private void X_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/x-ray_tetra.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("X-RAY TETRA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/x-ray_tetra.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("X-RAY TETRA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/x-ray_tetra.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("X-RAY TETRA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void Y_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/yuyu.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("YUYU");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/yuyu.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("YUYU");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/yuyu.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("YUYU");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
        }
        private void Z_Klik(object sender, RoutedEventArgs e)
        {
            if (flag == 0)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/zebra.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("ZEBRA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 1;
            }
            else if (flag == 1)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/zebra.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("ZEBRA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 2;
            }
            else if (flag == 2)
            {
                ImageLoad ImL = new ImageLoad();
                ImL.TampilGambar.Source = new BitmapImage(new Uri("/AppHCI2;component/imgobj/zebra.jpg", UriKind.Relative));
                ImL.NamaHewan.Content = String.Format("ZEBRA");
                Nullable<bool> windowMdl = ImL.ShowDialog();
                flag = 0;
            }
            
        }
        void QuitBTN_klik(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
