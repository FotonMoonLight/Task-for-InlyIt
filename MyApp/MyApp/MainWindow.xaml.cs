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
using MyApp.Pages;

namespace MyApp
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

        private void InShopBtn_Click(object sender, RoutedEventArgs e)
        {
            ShopPage page = new ShopPage();
            page.Show();
            this.Close();
        }

        private void InBucketBtn_Click(object sender, RoutedEventArgs e)
        {
            BucketPage page = new BucketPage();
            page.Show();
            this.Close();
        }
    }
}