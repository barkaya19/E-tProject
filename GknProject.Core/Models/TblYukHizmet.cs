using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblYukHizmet
    {
        public int StId { get; set; }
        public string StAciklama { get; set; } = null!;
        public int StType { get; set; }
        public int StDurum { get; set; }
        public DateTime StOlusturmaTarihi { get; set; }
    }
}
