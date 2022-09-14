using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblAktarimMerkeziBolge
    {
        public int StId { get; set; }
        public int? StMerkezId { get; set; }
        public int? StIl { get; set; }
        public string? StIlAd { get; set; }
        public int StIlce { get; set; }
        public string? StIlceAd { get; set; }
        public int StMahalle { get; set; }
        public string? StMahalleAd { get; set; }
    }
}
