using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMusteriOzellik
    {
        public int StOzellikId { get; set; }
        public string? StOzellikAdi { get; set; }
        public int StSira { get; set; }
        public int StDurum { get; set; }
        public int StOzelikTuruId { get; set; }
    }
}
