using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblGonderiUrunler
    {
        public int StId { get; set; }
        public int StShipmentId { get; set; }
        public string? StUrunAdi { get; set; }
        public string? StBarcode { get; set; }
        public int? StSubBarcodeNo { get; set; }
        public int? StMiktar { get; set; }
        public decimal? StEn { get; set; }
        public decimal? StBoy { get; set; }
        public decimal? StYukseklik { get; set; }
        public decimal? StDesi { get; set; }
        public decimal? StAgirlik { get; set; }
        public decimal? StHacim { get; set; }
        public decimal? StTutar { get; set; }
        public string? StGuId { get; set; }
        public int StDurum { get; set; }
        public DateTime StOlusturmatarihi { get; set; }
        public int? StOlusturanUser { get; set; }
    }
}
