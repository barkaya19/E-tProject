using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblGonderiDurumlari
    {
        public int StId { get; set; }
        public string? StAciklama { get; set; }
        public int? StSira { get; set; }
        public int? StDurum { get; set; }
    }
}
