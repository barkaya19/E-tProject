using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblYukHizmetSoz
    {
        public int StId { get; set; }
        public int StSozlesmeId { get; set; }
        public int StYukHizmetId { get; set; }
        public decimal StYukHizmetDeger { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
    }
}
