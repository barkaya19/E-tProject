using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblIlce
    {
        public int Id { get; set; }
        public string StIlceAdi { get; set; } = null!;
        public int StPlakaKodu { get; set; }
    }
}
