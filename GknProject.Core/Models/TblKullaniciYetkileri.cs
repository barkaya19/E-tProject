using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblKullaniciYetkileri
    {
        public int StId { get; set; }
        public int StPermissionId { get; set; }
        public int StUserId { get; set; }
        public int StAcces { get; set; }
        public DateTime StDateTime { get; set; }
    }
}
