using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Kqxs
    {
        public int MaKq { get; set; }
        public int? MaLvs { get; set; }
        public int? MaGiai { get; set; }
        public int? SoTrung { get; set; }
        public DateTime? Ngay { get; set; }

        public Giai MaGiaiNavigation { get; set; }
        public LoaiVeSo MaLvsNavigation { get; set; }
    }
}
