using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entitiy.Core.Entities
{
    public class Arac
    {
        [Key]
        public int AracID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string KM { get; set; }
        public string Fiyat { get; set; }
        public string Yıl { get; set; }
        public string Renk { get; set; }
        public string VitesTipi { get; set; }

        public bool Stoktami { get; set; } = true;

        public Müsteri Müsteri { get; set; }
        public List<Satis> Satis { get; set; }

        public override string ToString()
        {
            return KM + "KM " + Marka + " " + Renk + " " + Model;
        }

        //arac calass sdüzenlemeleriii
    }
}
