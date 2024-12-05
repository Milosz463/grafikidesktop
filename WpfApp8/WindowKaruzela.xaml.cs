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
        List<Obraz> listaObrazow = new List<Obraz>();
        int liczba { get; set; }

        public WindowKaruzela()
        {
            InitializeComponent();
            listaObrazow.Add(new Obraz("sigma.jpg"));
            listaObrazow.Add(new Obraz("sigma2.jpg"));
            listaObrazow.Add(new Obraz("sigma3.jpg"));
            listaObrazow.Add(new Obraz("sigma4.jpg"));
            
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
            image.Source = new BitmapImage(new Uri(listaObrazow[i].UrlObrazka, UriKind.Relative));
            polubienia.Text = listaObrazow[i].liczbaPolubien.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            listaObrazow[liczba].liczbaPolubien++;
            wyswietlObraz(liczba);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            listaObrazow[liczba].liczbaPolubien--;
            wyswietlObraz(liczba);

        }
    }
}
