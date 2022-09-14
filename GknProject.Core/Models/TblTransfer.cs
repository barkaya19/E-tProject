using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblTransfer
    {
        public int StId { get; set; }
        public int StAnaAktarmaMerkezi { get; set; }
        public int? StAracId { get; set; }
        public int? StSoforId { get; set; }
        public int? StOlusturanId { get; set; }
        public string? StNotlar { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
        public Guid? StGuId { get; set; }
        public int? StKullaniciId { get; set; }
        public long? StAracBarcode { get; set; }
        public int StDurum { get; set; }
    }
}
