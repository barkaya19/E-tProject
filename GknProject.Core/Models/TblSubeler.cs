using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblSubeler
    {
        public int StId { get; set; }
        public string? StSubeAdi { get; set; }
        public string? StBirimKodu { get; set; }
        public int StDurum { get; set; }
    }
}
