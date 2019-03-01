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

namespace _123456ModernFamily
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Variables
        //We don't want to do multiple calls to the same website
        //so we create only one client
        System.Net.WebClient webClient = new System.Net.WebClient();
        string fullOutput;
        public MainWindow()
        {
            InitializeComponent();
            //only download the file from the internet when the program starts
            fullOutput = webClient.DownloadString("http://api.tvmaze.com/singlesearch/shows?q=modern-family&embed=episodes");
        }

        private void btnFullOutput_Click(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = fullOutput;
        }

        private void btnGetSeason_Click(object sender, RoutedEventArgs e)
        {
            //put your code here - remember indexof and substring!
        }
    }
}
