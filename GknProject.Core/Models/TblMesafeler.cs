using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMesafeler
    {
        public int StId { get; set; }
        public int StBaslaIlId { get; set; }
        public int StBaslaIlceId { get; set; }
        public int StBitirIlId { get; set; }
        public int StBitirIlceId { get; set; }
        public int StMesafe { get; set; }
        public int StGun { get; set; }
    }
}
