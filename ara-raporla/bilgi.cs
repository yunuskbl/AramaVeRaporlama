using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ara_raporla
{
    class bilgi
    {
        public static string adi;
        public static string sadi;
        public static bool durum;

        public static bool durum1
        {
            get { return durum; }
            set { durum = value; }
        }

        public static string isim
        {            
            get { return adi; }
            set { adi = value; }            
        }
        public static string soyadi
        {
            get { return sadi; }
            set { sadi = value; }
        }

    }
}
