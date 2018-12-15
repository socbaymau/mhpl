using DAL;
using doan2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DAL
{
    class DAL_HDCT:DBconnect
    {
        string table = "HDCT";
        public DataTable getall()
        {
            string sql = "select * from " + table;
            return GetData(sql);
        }
        public bool ThanhToan(int ID)
        {
            string sql = "Update " + table + " Set TRANGTHAI=1 WHERE MAHDCT=" + ID;
            return Update(sql);
        }
        public DataTable timkiemSIM(String s)
        {
            string sql = "select * from " + table +" where IDSIM='"+s+"'";
            return GetData(sql);
        }
        public bool insert(DTO_HoaDon hd)
        {
            string sql = "insert into " + table + " values('" + hd.IDSIM + "','" + hd.TongTien + "'," + 0 + ",'" +hd.Ngay + "'," + hd.DotCuoc + ")";
            return Update(sql);
        }
        public DataTable getdatabyid()
        {
            string sql = "select MAHDCT,ts.MAKH , ts.IDSIM ,  TONGTIEN from CHITIETSD ct, THONGTINSIM ts , HDCT ht where ct.IDSIM = ts.IDSIM and ts.IDSIM = ht.IDSIM and DOTCUOC = (select Max(DOTCUOC) from DOTCUOC)";
            return GetData(sql);
        }
    }
}
