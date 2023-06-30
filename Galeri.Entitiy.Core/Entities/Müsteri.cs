using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entitiy.Core.Entities
{
    public class Müsteri
    {
        [Key]
        public int MüsteriID { get; set; }
        public string AD { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }

        public List<Arac> Arac { get; set; }

        public List<Satis> Satis { get; set; }
        public override string ToString()
        {
            return AD + " " + Soyad;
        }
    }
}
