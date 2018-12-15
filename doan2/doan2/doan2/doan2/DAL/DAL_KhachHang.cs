using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using doan2.DTO;

namespace doan2.DAL
{
    public class DAL_KhachHang : DBconnect
    {
        string table = "KHACHHANG";
        public DataTable getall()
        {
            string sql = "select * from " + table;
            return GetData(sql);
        }
        public DataTable Search(string s)
        {
            string sql = " Select * from " + table + " where MAKH='" + s + "' or CMND ='" + s + "'";
            return GetData(sql);
        }

        public bool insert_kh(DTO_KhachHang dkh)
        {
            string sql = "insert into " + table + " values('" + dkh.hoten + "','" + dkh.cmnd + "','" + dkh.nghenghiep + "','" + dkh.chucvu + "','" + dkh.diachi + "','"+dkh.email+"')";
            return Update(sql);
        }

        public bool update_kh(DTO_KhachHang dkh)
        {
            string sql = "Update " + table + " Set TENKH='" + dkh.hoten + "',CMND='" + dkh.cmnd + "',NGHENGHIEP='" + dkh.nghenghiep + "',CHUCVU='" + dkh.chucvu + "',DIACHI='" +dkh.diachi+ "',EMAIL='"+dkh.email+"' WHERE MAKH='" + dkh.makh+"'";
            return Update(sql);
        }
        public bool delete_kh(string s)
        {
            string sql = "delete from  " + table + " where MAKH='" + s + "'";
            return Update(sql);
        }
    }
}
