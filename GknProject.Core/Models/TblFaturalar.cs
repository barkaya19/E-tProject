using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblFaturalar
    {
        public long StFaturaId { get; set; }
        public string? StFaturaPrefix { get; set; }
        public int StMusteriId { get; set; }
        public DateTime? StBaslangic { get; set; }
        public DateTime? StBitis { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
        public int? StOlusturanKullanici { get; set; }
        public int StGonderiAdet { get; set; }
        public decimal StFaturaTutar { get; set; }
        public decimal? StToplamKdv { get; set; }
        public int? StAcentaId { get; set; }
        public string? StFaturaPeriyod { get; set; }
    }
}
