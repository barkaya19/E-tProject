using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblSozlemeler
    {
        public int StSozlesmeId { get; set; }
        public string? StSozAdi { get; set; }
        public DateTime? StSozBas { get; set; }
        public DateTime? StSozBit { get; set; }
        public double? StSozOdemeGun { get; set; }
        public int? StSozAcentaId { get; set; }
        public double? StSozAcentaOran { get; set; }
        public int StDurum { get; set; }
        public int? StSozCalisDrm { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
        public int StDosya { get; set; }
        public int StKoli { get; set; }
        public int StPalet { get; set; }
        public int StRulo { get; set; }
        public Guid? StGuId { get; set; }
    }
}
