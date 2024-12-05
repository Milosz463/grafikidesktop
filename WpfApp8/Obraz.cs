using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    public class Obraz
    {
        public int liczbaPolubien { get; set; }
        public string UrlObrazka { get; set; }

        public Obraz( string urlObrazka)
        {
            UrlObrazka = urlObrazka;
            liczbaPolubien = 0;
        }
    }
}
