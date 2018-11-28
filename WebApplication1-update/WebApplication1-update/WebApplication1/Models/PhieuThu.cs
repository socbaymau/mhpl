using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PhieuThu
    {
        public int MaPt { get; set; }
        public int? MaDl { get; set; }
        public DateTime? Ngay { get; set; }
        public double? SoTien { get; set; }

        public DaiLy MaDlNavigation { get; set; }
    }
}
