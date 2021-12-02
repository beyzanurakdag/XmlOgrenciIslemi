using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DTarihi { get; set; }
        public string Sinif { get; set; }
        private byte _yas = 0;
        public byte Yas
        {
            get
            {                           
                _yas=Convert.ToByte(DateTime.Now.Year- DTarihi.Year);
                return _yas;
            }
        }
        public bool SecmeliDersAlıyorMu { get; set; }
        public List<string> AldigiSecmeliDersler { get; set; } = new List<string>();
        public override string ToString()
        {
            return this.Ad +" "+ this.Soyad.ToUpper() + " - "+ this.Yas + " yaşında ve " + this.AldigiSecmeliDersler.Count + " adet seçmeli dersi var."; 

        }
    }
}
