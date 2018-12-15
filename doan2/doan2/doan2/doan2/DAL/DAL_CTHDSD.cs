using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DAL
{
    class DAL_CTHDSD:DBconnect
    {
        string table = "CHITIETSD";
        public DataTable getall()
        {
            string sql = "select * from " + table;
            return GetData(sql);
        }
        public DataTable getCTSDIDSIM(String s)
        {
            string sql = "select * from " + table + " WHERE IDSIM='"+ s + "'";
            return GetData(sql);
        }
        public DataTable getPhi(DateTime TGBD,DateTime TGKT)
        {
            String sql = "select IDSIM,SUM(CUOCPHI) as TONG from CHITIETSD where TGKT >= '" + TGBD.ToString("yyyy/MM/dd") + "' and TGKT<= '" + TGKT.ToString("yyyy/MM/dd") + "' group by IDSIM";
            return GetData(sql);
        }
    }
}
