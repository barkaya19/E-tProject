using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMusteriNotlari
    {
        public int StMusteriNotId { get; set; }
        public int? StMusteriId { get; set; }
        public DateTime? StNotTarihi { get; set; }
        public string? StNot { get; set; }
        public int? StOlusturanKullaniciId { get; set; }
        public DateTime? StNotHatTarih { get; set; }
        public string? StNotMail { get; set; }
    }
}
