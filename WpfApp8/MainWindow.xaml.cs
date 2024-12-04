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

namespace WpfApp8
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            image.Source = new BitmapImage(new Uri("sigma2.jpg",UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<string> listaObrazkow = new List<string>();
            listaObrazkow.Add("sigma.jpg");
            listaObrazkow.Add("sigma2.jpg");
            listaObrazkow.Add("sigma3.jpg");
            listaObrazkow.Add("sigma4.jpg");
            Random random= new Random();
            int indekst = random.Next(listaObrazkow.Count);
            image.Source = new BitmapImage(new Uri(listaObrazkow[indekst], UriKind.Relative));
        }
    }
}
