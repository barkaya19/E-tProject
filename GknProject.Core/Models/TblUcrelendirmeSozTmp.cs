using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblUcrelendirmeSozTmp
    {
        public int StId { get; set; }
        public int StSozlesmeId { get; set; }
        public int StTasFirmaId { get; set; }
        public int? StBasKm { get; set; }
        public int? StBitKm { get; set; }
        public int? StBasDesi { get; set; }
        public int? StBitDesi { get; set; }
        public decimal? StTutar { get; set; }
        public decimal? StUcretAlici { get; set; }
        public decimal? StAyniGun { get; set; }
        public decimal StIadeOrani { get; set; }
        public decimal StArtanDesi { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
        public int StPaketTipi { get; set; }
        public decimal? StBolgeDisi { get; set; }
    }
}
