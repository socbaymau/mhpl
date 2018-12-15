using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DTO
{
    class DTO_HoaDon
    {
        private int mAHD;
        private String iDSIM;
        private int tongTien;
        private int trangThai;
        private DateTime ngay;
        private int dotCuoc;

        public int MAHD { get => mAHD; set => mAHD = value; }
        public string IDSIM { get => iDSIM; set => iDSIM = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public int DotCuoc { get => dotCuoc; set => dotCuoc = value; }
    }
}
