using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan2.DTO;
using DAL;
using System.Data;

namespace doan2.DAL
{
    public class DAL_CTSD : DBconnect 
    {
        string table = "CHITIETSD";
        public bool Insert_CTSD(DTO_CTSD dct)
        {          
            string sql = "Insert into  "+table+"  values('"+dct.Id_sim+"','"+dct.Tgbd.ToString("yyyy-MM-dd HH:mm:ss") + "','"+dct.Tgkt.ToString("yyyy-MM-dd HH:mm:ss") + "','"+dct.Sophutsudung+"','"+dct.Cuocphi+"')";
            return Update(sql);
        }
        public DataTable listall()
        {
            string sql = "select * from "+ table;
            return GetData(sql);
        }
        
        public DataTable getID()
        {
            string sql = "select IDSIM from THONGTINSIM";
            return GetData(sql);
        }
        public DataTable search(string s)
        {
            string sql = "select * from " + table + " where IDCTSD='" + s + "' or IDSIM='" + s + "'";
            return GetData(sql);
        }
    }
}
