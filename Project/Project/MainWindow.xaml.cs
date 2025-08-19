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
using Project.Data;
using Project.View;
using Project.ViewModel;
namespace Project
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

        private void ShopBtn_Click(object sender, RoutedEventArgs e)
        {
            ShopPage shopPage = new ShopPage();
            shopPage.Show();
            this.Close();
        }

        private void BucketBtn_Click(object sender, RoutedEventArgs e)
        {
            BucketPage bucketPage = new BucketPage();
            bucketPage.Show();
            this.Close();
        }
    }
}