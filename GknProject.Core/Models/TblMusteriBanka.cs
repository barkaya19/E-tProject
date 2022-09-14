using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMusteriBanka
    {
        public int StBankaBilgiId { get; set; }
        public int? StMusteriId { get; set; }
        public string? StBankaId { get; set; }
        public string? StSubeAdi { get; set; }
        public string? StSubeKodu { get; set; }
        public string? StHesapNo { get; set; }
        public string? StIban { get; set; }
        public string? StParaBirimiId { get; set; }
        public string? StAdSoyad { get; set; }
    }
}
