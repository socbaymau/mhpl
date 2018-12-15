using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using doan2.DTO;
using DAL;

namespace doan2.DAL
{
    public class DAL_SIM : DBconnect
    {
        string table = "THONGTINSIM";

        public bool INSERT_SIM(DTO_Sim ds)
        {
            string sql = " Insert into " + table + " values('"+ds.Id_sim+"','"+ds.Ma_kh+"','"+ds.Tinhtrang+"')";
            return Update(sql);
        }
        public bool update_sim(DTO_Sim ds)
        {
            string sql = "Update " + table + " set MAKH='"+ds.Ma_kh+"' TRINHTRANG='"+ds.Tinhtrang+"'";
            return Update(sql);
        }
        public DataTable getall()
        {
            string sql = " select * from " + table;
            return GetData(sql);
        }
        public bool delete_sim(string s)
        {
            string sql = " drop from " + table + " where IDSIM = '" + s + "'";
            return Update(sql);
        }
        public DataTable search(string s)
        {
            string sql = "select * from " + table + " where IDSIM='" + s + "'";
            return GetData(sql);
        }
        public DataTable getall_kh()
        {
            string sql = " select MAKH from KHACHHANG";
            return GetData(sql) ;
        }
        
    }
}
