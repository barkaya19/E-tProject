using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblKullanicilar
    {
        public int StKullaniciId { get; set; }
        public string? StKullaniciAdi { get; set; }
        public string? StAd { get; set; }
        public string? StSoyad { get; set; }
        public string? StSifre { get; set; }
        public int? StDurum { get; set; }
        public DateTime? StGirisZamani { get; set; }
        public string? StIp { get; set; }
        public string? StMailAdres { get; set; }
        public string StMobileToken { get; set; } = null!;
        public int StAktarmaMerkezi { get; set; }
        public int StMobilYukleSeferId { get; set; }
        public DateTime? StMobilYukleSeferTarihi { get; set; }
        public int? StMobilBosaltSeferId { get; set; }
        public DateTime? StMobilBosaltSeferTarihi { get; set; }
    }
}
