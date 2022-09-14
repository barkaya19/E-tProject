using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMusteriTemsilci
    {
        public int StMusteriTemsilciId { get; set; }
        public int? StMusteriId { get; set; }
        public string? StAdSoyad { get; set; }
        public DateTime? InsertedDate { get; set; }
        public int? StDurum { get; set; }
        public string? StTelNo { get; set; }
        public string? StMailAdres { get; set; }
    }
}
