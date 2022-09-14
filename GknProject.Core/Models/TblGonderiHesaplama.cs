using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblGonderiHesaplama
    {
        public int StGonderiId { get; set; }
        public int StKuralId { get; set; }
        public int StArtanDesiId { get; set; }
        public decimal StKuralTutar { get; set; }
        public decimal StKuralAyniGun { get; set; }
        public decimal StKuralAlici { get; set; }
        public decimal StKuralArtanDesi { get; set; }
        public decimal StKuralHesapAgirlik { get; set; }
        public decimal StYukHizmetTutar { get; set; }
        public decimal StSozlesmeTutar { get; set; }
        public decimal StPoligonTutar { get; set; }
        public int StArtanDesiMiktar { get; set; }
        public decimal StArtanDesiTutar { get; set; }
        public decimal StPostaHizmetBedeli { get; set; }
        public decimal StToplamTutar { get; set; }
        public decimal StKdvTutar { get; set; }
        public string? StYukHizmetJson { get; set; }
        public int? StErrId { get; set; }
        public string? StErr { get; set; }
    }
}
