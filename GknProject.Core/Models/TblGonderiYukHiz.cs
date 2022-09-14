using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblGonderiYukHiz
    {
        public int StId { get; set; }
        public int? StGonderiId { get; set; }
        public int? StYukHizmetId { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
        public int? StOlusturan { get; set; }
    }
}
