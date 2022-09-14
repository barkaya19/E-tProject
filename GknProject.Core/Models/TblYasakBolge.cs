using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblYasakBolge
    {
        public int StId { get; set; }
        public int? StIlId { get; set; }
        public string? StIlAd { get; set; }
        public int StIlceId { get; set; }
        public string? StIlceAd { get; set; }
        public int StMahalleId { get; set; }
        public string? StMahalleAd { get; set; }
        public int StCariId { get; set; }
        public int? StKargoId { get; set; }
        public DateTime? StOlusturma { get; set; }
        public int? StOlusturan { get; set; }
    }
}
