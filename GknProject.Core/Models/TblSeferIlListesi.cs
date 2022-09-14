using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblSeferIlListesi
    {
        public int StId { get; set; }
        public int? StSeferId { get; set; }
        public int? StIlId { get; set; }
        public string? StIlAd { get; set; }
        public DateTime? StCikisTarihi { get; set; }
        public DateTime? StTahminiVarisTarihi { get; set; }
        public int StDurum { get; set; }
        public Guid StGuId { get; set; }
        public int? StKullaniciId { get; set; }
    }
}
