using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Galeri
    {
        private List<Araba> Arabalar = new List<Araba>();

        public void ArabaEkle(Araba a)
        {
            Arabalar.Add(a);
        }

        public void ArabaSat(Araba a)
        {
            Arabalar.Remove(a);
        }

        public string ArabalariListele()
        {
            string bilgi = "";
            foreach (Araba araba in Arabalar)
            {
                bilgi += "\n Marka: " + araba.Marka +
                        "\n Model: " + Convert.ToInt16(araba.Model) +
                        "\n Renk: " + araba.Renk + "\n\n";
            }
            return bilgi;
        }

        public List<Araba> ArabaListesiVer()
        {
            return Arabalar;
        }
    }
}
