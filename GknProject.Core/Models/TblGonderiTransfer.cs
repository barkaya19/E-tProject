using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblGonderiTransfer
    {
        public int StId { get; set; }
        public int? StTransferId { get; set; }
        public int? StGonderiId { get; set; }
        public DateTime StCreateDate { get; set; }
    }
}
