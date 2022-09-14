using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblSeferTransferMerkezi
    {
        public int StId { get; set; }
        public int? StSeferId { get; set; }
        public int? StTransferMerkeziId { get; set; }
        public DateTime? StCikisTarihi { get; set; }
        public DateTime? StTahminiVarisTarihi { get; set; }
        public int StDurum { get; set; }
        public Guid StGuId { get; set; }
        public int? StKullaniciId { get; set; }
        public string StMuhurNo { get; set; } = null!;
        public int StMuhurleyen { get; set; }
        public DateTime? StMuhurlemeZamani { get; set; }
        public int StMuhruAcan { get; set; }
        public DateTime? StMuhurAcmaZamani { get; set; }
    }
}
