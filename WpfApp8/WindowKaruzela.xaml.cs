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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp8
{
    /// <summary>
    /// Logika interakcji dla klasy WindowKaruzela.xaml
    /// </summary>
    public partial class WindowKaruzela : Window
    {
        List<string> listaObrazow = new List<string>();
        int liczba { get; set; }

        public WindowKaruzela()
        {
            InitializeComponent();
            listaObrazow.Add("sigma.jpg");
            listaObrazow.Add("sigma2.jpg");
            listaObrazow.Add("sigma3.jpg");
            listaObrazow.Add("sigma4.jpg");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            liczba--;
            if (liczba < 0)
            {
                liczba = listaObrazow.Count - 1;
            }
            
            wyswietlObraz(liczba);
            
            
            

           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            liczba++;
            if (liczba == listaObrazow.Count)
            {
                liczba = 0;
            }
            
            wyswietlObraz(liczba);

            
            
          
        }
        void wyswietlObraz(int i)
        {
            image.Source = new BitmapImage(new Uri(listaObrazow[i], UriKind.Relative));
        }
    }
}
