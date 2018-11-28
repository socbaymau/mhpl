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
        public int? SoLuongGiai { get; set; }
        public int? SoLanQuay { get; set; }
        public int? So { get; set; }
        public double? TriGia { get; set; }

        public ICollection<Kqxs> Kqxs { get; set; }
    }
}
