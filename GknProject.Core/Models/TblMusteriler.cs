using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMusteriler
    {
        public int StMusteriId { get; set; }
        public int StAnaHesapId { get; set; }
        public string? StCariKod { get; set; }
        public int? StBolgeId { get; set; }
        public int? StSubeId { get; set; }
        public int? StHesapTipiId { get; set; }
        public string? StTahsilatTipi { get; set; }
        public string? StAd { get; set; }
        public string? StSoyad { get; set; }
        public string? StTcNo { get; set; }
        public string? StUyruk { get; set; }
        public string? StCinsiyet { get; set; }
        public string? StTelefonNo { get; set; }
        public int? StSehirId { get; set; }
        public string? StSehirAd { get; set; }
        public int? StIlceId { get; set; }
        public string? StIlceAd { get; set; }
        public int? StMahalleId { get; set; }
        public string? StMahalleAd { get; set; }
        public string? StCadde { get; set; }
        public string? StApartman { get; set; }
        public string? StAptNo { get; set; }
        public string? StDaireNo { get; set; }
        public string? StPostaKodu { get; set; }
        public string? StUnvani { get; set; }
        public string? StVergiDairesi { get; set; }
        public string? StVergiNo { get; set; }
        public int? StHesapTuruId { get; set; }
        public string? StMagazaKodu { get; set; }
        public int StOdemeTipiId { get; set; }
        public int? StCariDisSubesiId { get; set; }
        public int? StCariSuspanSubeId { get; set; }
        public int? StMusteriTemsilciId { get; set; }
        public double? StBeklenenCiro { get; set; }
        public int? StFaturalasmaSuresi { get; set; }
        public int? StMusteriTipId { get; set; }
        public int? StOdemeVadesi { get; set; }
        public int? StIhbarCalismaGun { get; set; }
        public int? StSozlesmeId { get; set; }
        public string? StIhbarCalismaSaat { get; set; }
        public string? StKullaniciAdi { get; set; }
        public string? StSifre { get; set; }
        public int StHerkeseGonder { get; set; }
        public int? StAcentaId { get; set; }
        public int StAlOdBenSozHesap { get; set; }
        public string? StYetAd { get; set; }
        public string? StYetSoyad { get; set; }
        public string? StYetUyruk { get; set; }
        public string? StYetTc { get; set; }
        public string? StYetCins { get; set; }
        public string? StYetTel { get; set; }
        public int? StYetSehirId { get; set; }
        public string? StYetSehirAd { get; set; }
        public int? StYetIlceId { get; set; }
        public string? StYetIlceAd { get; set; }
        public int? StYetMahId { get; set; }
        public string? StYetMahAd { get; set; }
        public string? StYetCadde { get; set; }
        public string? StYetApartman { get; set; }
        public string? StYetAptNo { get; set; }
        public string? StYetDaireNo { get; set; }
        public string? StYetPostaKodu { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
        public int? StOlusturanKulaniciId { get; set; }
        public string? StAdUnvan { get; set; }
        public Guid? StGuId { get; set; }
        public int? StDurum { get; set; }
        public DateTime? StGirisZamani { get; set; }
        public int StPerGbcari { get; set; }
        public int StPerGbyb { get; set; }
        public int StPerGbyk { get; set; }
        public int StPerAbcari { get; set; }
        public int StPerAbyb { get; set; }
        public int StPerAbyk { get; set; }
        public int StPerAbadres { get; set; }
        public string? StDefaultFormAb { get; set; }
        public string? StDefaultFormGb { get; set; }
    }
}
