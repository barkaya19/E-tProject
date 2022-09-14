using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblTasimaFirmalariSoz
    {
        public int StId { get; set; }
        public int StSozlesmeId { get; set; }
        public int StTasFirmaId { get; set; }
        public int? StDurum { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
    }
}
