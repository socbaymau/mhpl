using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Giai
    {
        public Giai()
        {
            Kqxs = new HashSet<Kqxs>();
        }

        public int MaGiai { get; set; }
        public string TenGiai { get; set; }
        public decimal? SoTien { get; set; }
        public string GhiChu { get; set; }

        public ICollection<Kqxs> Kqxs { get; set; }
    }
}
