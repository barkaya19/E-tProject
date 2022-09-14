using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblGidilenBolge
    {
        public int StId { get; set; }
        public int StIlId { get; set; }
        public string? StIlAd { get; set; }
        public int StIlceId { get; set; }
        public string? StIlceAd { get; set; }
        public int StMahalleId { get; set; }
        public string? StMahalleAd { get; set; }
        public int StCariId { get; set; }
        public int? StKargoId { get; set; }
        public int StPzt { get; set; }
        public int StSali { get; set; }
        public int StCrs { get; set; }
        public int StPers { get; set; }
        public int StCum { get; set; }
        public int StCmrt { get; set; }
        public int StPzr { get; set; }
        public decimal StEkTutar { get; set; }
        public DateTime? StOlusturma { get; set; }
        public int? StOlusturan { get; set; }
        public int? StAktarmaMerkezi { get; set; }
    }
}
