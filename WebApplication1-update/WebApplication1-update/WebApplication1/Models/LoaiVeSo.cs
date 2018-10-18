using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class LoaiVeSo
    {
        public LoaiVeSo()
        {
            Kqxs = new HashSet<Kqxs>();
            PhanPhoi = new HashSet<PhanPhoi>();
            SldangKy = new HashSet<SldangKy>();
        }

        public int MaLvs { get; set; }
        public string Tinh { get; set; }
        public string TinhTrang { get; set; }

        public ICollection<Kqxs> Kqxs { get; set; }
        public ICollection<PhanPhoi> PhanPhoi { get; set; }
        public ICollection<SldangKy> SldangKy { get; set; }
    }
}
