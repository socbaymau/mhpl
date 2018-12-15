using doan2.DAL;
using doan2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.BUS
{
    class BUS_HDCT
    {
        DAL_HDCT hdct = new DAL_HDCT();
        public DataTable getall_kh()
        {
            return hdct.getall();
        }
        public bool ThanhToan(int s)
        {
            return hdct.ThanhToan(s);
        }
        public DataTable timkiemSIM(String s)
        {
            return hdct.timkiemSIM(s);
        }
        public DataTable GetdatabyID()
        {
            return hdct.getdatabyid();
        }
        public void insert(DateTime NgayBD, DateTime NgayKT, DTO_DotCuoc dotcuoc)
        {
            DAL_CTHDSD ctsd = new DAL_CTHDSD();
            DataTable dt = ctsd.getPhi(NgayBD, NgayKT);
            DTO_DotCuoc dtodotcuoc = new DTO_DotCuoc();
            dtodotcuoc.DotCuoc = dotcuoc.DotCuoc + 1;
            dtodotcuoc.NgayBD = NgayBD;
            dtodotcuoc.NgayKT = NgayKT;
            new DAL_DotCuoc().insert(dtodotcuoc);
            foreach (DataRow row in dt.Rows)
            {
                DTO_HoaDon hd = new DTO_HoaDon();
                hd.IDSIM = row["IDSIM"].ToString();
                hd.TongTien = int.Parse(row["TONG"].ToString());
                hd.TrangThai = 0;
                hd.Ngay = DateTime.Today;
                hd.DotCuoc = dtodotcuoc.DotCuoc;
                hdct.insert(hd);
            }
        }
    }
}
