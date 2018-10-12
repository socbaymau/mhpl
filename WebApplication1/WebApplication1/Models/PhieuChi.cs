using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PhieuChi
    {
        public int MaPc { get; set; }
        public int? MaDl { get; set; }
        public DateTime? Ngay { get; set; }
        public decimal? SoTien { get; set; }
        public string NoiDung { get; set; }

        public DaiLy MaDlNavigation { get; set; }
    }
}
