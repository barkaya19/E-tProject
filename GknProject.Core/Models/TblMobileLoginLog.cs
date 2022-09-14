using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblMobileLoginLog
    {
        public int StId { get; set; }
        public string? StMobilToken { get; set; }
        public string? StBarcode { get; set; }
    }
}
