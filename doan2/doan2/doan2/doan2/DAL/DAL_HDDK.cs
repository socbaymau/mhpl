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
    class DAL_HDDK : DBconnect
    {
        string table = "HOADONDK";
        //public DataTable getAll()
        //{
        //    string sql = "select * from " + table;
        //    return GetData(sql);
        //}
        public DataTable getAll()
        {
            string sql = "select a.MAHDDK , a.IDSIM , b.MAKH ,a.Ngay, a.CUOCDK  from HOADONDK a , THONGTINSIM b where a.IDSIM =b.IDSIM";
            return GetData(sql);
        }
        public bool insert(DTO_HoaDonDangKy hd)
        {
            string sql = "insert into " + table + " values('" + hd.Ma_kh + "','" + hd.Phihoamang + "','" + hd.Ngay + "')";
            return Update(sql);
        }
        public DataTable search(string s)
        {
            string sql = "select * from " + table + " where IDSIM='" + s + "'";
            return GetData(sql);
        }
        public DataTable get_idsim()
        {
            string sql = "select IDSIM from THONGTINSIM";
            return GetData(sql);
        }
    }
}
