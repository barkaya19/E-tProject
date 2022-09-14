using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblAcentum
    {
        public int StAcentaId { get; set; }
        public string? StAcentaAdi { get; set; }
        public int? StDurum { get; set; }
        public DateTime? StOlusturmaTarihi { get; set; }
    }
}
