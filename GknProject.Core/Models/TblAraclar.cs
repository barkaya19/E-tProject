using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblAraclar
    {
        public int StId { get; set; }
        public string? StPlaka { get; set; }
        public int? StAracDesi { get; set; }
        public int StSofor { get; set; }
        public string? StAracTip { get; set; }
        public string? StAracToken { get; set; }
        public int StDurum { get; set; }
    }
}
