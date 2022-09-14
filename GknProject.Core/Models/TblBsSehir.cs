using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblBsSehir
    {
        public int Id { get; set; }
        public string Adi { get; set; } = null!;
        public string? Geo { get; set; }
        public int? IlId { get; set; }
        public double? Laty { get; set; }
        public double? Longx { get; set; }
        public int? Nufus { get; set; }
        public int? Uavtkodu { get; set; }
        public int? UlkeId { get; set; }
    }
}
