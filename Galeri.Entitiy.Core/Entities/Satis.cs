using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entitiy.Core.Entities
{
    public class Satis
    {

        [Key]
        public int SatisID { get; set; }
        public int AracID { get; set; }
        public int MüsteriID { get; set; }

        [Required]
        public Decimal SatisFiyatı { get; set; }

        
        //command yeni düzenlemeler blablabla
    }
}
