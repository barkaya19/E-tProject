using System;
using System.Collections.Generic;

namespace GknProject.Core.Models
{
    public partial class TblYetkiler
    {
        public int StId { get; set; }
        public string? StItemTeype { get; set; }
        public string? StMenuItem { get; set; }
        public string? StMenuItemChild { get; set; }
        public string? StFunctionName { get; set; }
        public string? StPageName { get; set; }
        public string? StComment { get; set; }
        public string? StColor { get; set; }
    }
}
