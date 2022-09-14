using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMusteriAdresler
    {
        public int StAdresId { get; set; }
        public int? StMusteriId { get; set; }
        public string? StAdresTipiId { get; set; }
        public string? StAdresAdi { get; set; }
        public int? StIl { get; set; }
        public string? StIlAd { get; set; }
        public int? StIlce { get; set; }
        public string? StIlceAd { get; set; }
        public int? StSemt { get; set; }
        public string? StSemtAd { get; set; }
        public string? StCadde { get; set; }
        public string? StApartman { get; set; }
        public string? StBinaNo { get; set; }
        public string? StDaireNo { get; set; }
        public string? StPostaKodu { get; set; }
        public string? StEkUcretAciklama { get; set; }
        public double? StEkUcret { get; set; }
        public string? StTelefon { get; set; }
        public string? StGsm { get; set; }
        public string? StFax { get; set; }
        public string? StEposta { get; set; }
        public string? StKisi { get; set; }
        public string? SGuId { get; set; }
        public int? StOlusturanKulaniciId { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
    }
}
