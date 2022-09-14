using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMusteriOzellikDurum
    {
        public int StId { get; set; }
        public int? StMusteriId { get; set; }
        public int? StIzinId { get; set; }
        public int StDurum { get; set; }
    }
}
