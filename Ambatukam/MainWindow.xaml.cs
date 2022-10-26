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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ambatukam
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

        string ambatukamPath = System.AppDomain.CurrentDomain.BaseDirectory +"\\AmbatukamFiles\\Ambatukam.mp4";
        private void ambatukamBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(ambatukamPath);
            videoPlayer.Source = obj;
        }

        string ambatublouPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\AmbatukamFiles\\Ambatublou.mp4";
        private void ambatublouBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(ambatublouPath);
            videoPlayer.Source = obj;
        }

        string ambatukaaaPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\AmbatukamFiles\\Ambatukaaa.mp4";
        private void ambatukaaaa_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(ambatukaaaPath);
            videoPlayer.Source = obj;
        }

        string omaygatPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\AmbatukamFiles\\Omaygat.mp4";
        private void omaygatBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(omaygatPath);
            videoPlayer.Source = obj;
        }

        string ambasingPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\AmbatukamFiles\\Ambasing.mp4";
        private void ambasingBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(ambasingPath);
            videoPlayer.Source = obj;
        }

        string plugPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\AmbatukamFiles\\PLUGITIN.mp4";
        private void plugItInBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(plugPath);
            videoPlayer.Source = obj;
        }

        string ambatucryPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\AmbatukamFiles\\Ambatucry.mp4";
        private void ambatucryBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(ambatucryPath);
            videoPlayer.Source = obj;
        }

        string ambatukamYesIAmPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\AmbatukamFiles\\AmbatukamYesIAm.mp4";
        private void yesIAmBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(ambatukamYesIAmPath);
            videoPlayer.Source = obj;
        }

        string ambatunatPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\AmbatukamFiles\\Ambatunat.mp4";
        private void ambatunatBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(ambatunatPath);
            videoPlayer.Source = obj;
        }

        string ambatukamEUHPath = System.AppDomain.CurrentDomain.BaseDirectory + "\\AmbatukamFiles\\AmbatukamEUH.mp4";
        private void ambatukamEUHBtn_Click(object sender, RoutedEventArgs e)
        {
            Uri obj = new Uri(ambatukamEUHPath);
            videoPlayer.Source = obj;
        }
    }
}
