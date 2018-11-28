using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PhieuChi
    {
        public int MaPc { get; set; }
        public string TenPhieuChi { get; set; }
        public DateTime? Ngay { get; set; }
        public double? SoTien { get; set; }
        public string NoiDung { get; set; }
    }
}
