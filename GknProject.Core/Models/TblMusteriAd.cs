using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMusteriAd
    {
        public int AdId { get; set; }
        public int? AdStMusteriId { get; set; }
        public Guid? AdStMusteriGuId { get; set; }
        public string? AdStAd { get; set; }
        public string? AdStSoyad { get; set; }
        public string? AdStTc { get; set; }
        public string? AdStUyruk { get; set; }
        public string? AdStCins { get; set; }
        public string? AdStTel { get; set; }
        public int? AdStIl { get; set; }
        public string? AdStIlAd { get; set; }
        public int? AdStIlce { get; set; }
        public string? AdStIlceAd { get; set; }
        public int? AdStSemt { get; set; }
        public string? AdStSemtAd { get; set; }
        public string? AdStCadde { get; set; }
        public string? AdStApartman { get; set; }
        public string? AdStBinaNo { get; set; }
        public string? AdStDaireNo { get; set; }
        public string? AdStPostaKodu { get; set; }
        public string? AdStIlgiliKisi { get; set; }
        public string? AdStIlgiliTelefon { get; set; }
        public string? AdStIlgiliGsm { get; set; }
        public string? AdStIlgiliEposta { get; set; }
        public int? AdOlusturan { get; set; }
        public DateTime AdOlusturmaTarihi { get; set; }
        public string? AdStVergiDairesi { get; set; }
        public string? AdStVergiNo { get; set; }
        public int AdSahisMi { get; set; }
        public string? AdUnvan { get; set; }
        public string? AdHash { get; set; }
    }
}
