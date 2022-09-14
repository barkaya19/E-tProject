using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblGonderiler
    {
        public int StId { get; set; }
        public long? StBarcode { get; set; }
        public int? StGondericiTip { get; set; }
        public int? StGondericiId { get; set; }
        public int? StAliciTip { get; set; }
        public int? StAliciId { get; set; }
        public int? StPaketTipi { get; set; }
        public int? StServisTipi { get; set; }
        public int? StOdemeSekli { get; set; }
        public int? StOdemeFirmaId { get; set; }
        public decimal? StRiskMalKiy { get; set; }
        public decimal? StSigBedel { get; set; }
        public decimal? StMalBedel { get; set; }
        public decimal? StNavlun { get; set; }
        public string? StIrsaliyeFatNo { get; set; }
        public string? StMusteriRefNo { get; set; }
        public string? StTeslimMail { get; set; }
        public string? StBilgiGirisRefNo { get; set; }
        public int? StToplamaSubeId { get; set; }
        public DateTime? StTeslimZamaniOng { get; set; }
        public DateTime? StTeslimZamani { get; set; }
        public int StTahminiTeslimGun { get; set; }
        public string? StYukHizmet { get; set; }
        public string? StGondericiAd { get; set; }
        public string? StAliciAd { get; set; }
        public int StGonderiAdet { get; set; }
        public int StGonderiDurumu { get; set; }
        public int? StOlusturan { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
        public Guid StGuId { get; set; }
        public int StMesafe { get; set; }
        public int StTasiyiciId { get; set; }
        public int? StEklemeTip { get; set; }
        public int? StAliciAdresId { get; set; }
        public int StFaturaId { get; set; }
        public int StZimmet { get; set; }
        public int StCikisAkMer { get; set; }
        public int StVarisAkMer { get; set; }
        public int StTransfer { get; set; }
        public int StTransferTmp { get; set; }
    }
}
