using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class DaiLy
    {
        public DaiLy()
        {
            CongNo = new HashSet<CongNo>();
            PhanPhoi = new HashSet<PhanPhoi>();
            PhieuThu = new HashSet<PhieuThu>();
            SldangKy = new HashSet<SldangKy>();
        }

        public int MaDl { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public int? HoaHong { get; set; }
        public string TinhTrang { get; set; }

        public ICollection<CongNo> CongNo { get; set; }
        public ICollection<PhanPhoi> PhanPhoi { get; set; }
        public ICollection<PhieuThu> PhieuThu { get; set; }
        public ICollection<SldangKy> SldangKy { get; set; }
    }
}
