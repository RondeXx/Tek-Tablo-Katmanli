using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAd { get; set; }
        public IList<Personel> Personelis { get; set; }

    }
}
