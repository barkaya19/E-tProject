using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblTransferMuhurListe
    {
        public int StId { get; set; }
        public int? StTransferId { get; set; }
        public int? StKullaniciId { get; set; }
        public string? StMuhurNo { get; set; }
        public DateTime StCreateDate { get; set; }
        public string? StAksiyon { get; set; }
        public int? StAksiyonId { get; set; }
    }
}
