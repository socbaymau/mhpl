using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using doan2.DTO;

namespace doan2.DAL
{
    class DAL_GiaCuoc: DBconnect
    {
        string table = "GIACUOC";
        public DataTable getAll()
        {
            string sql = "select * from " + table;
            return GetData(sql);
        }
        public bool update_kh(DTO_GiaCuoc gc)
        {
            string sql = "Update " + table + " Set TGBD='" + gc.thoigianbatdau + "',TGKT='" + gc.thoigiankethuc + "',GIACUOC='" + gc.giacuoc + "' WHERE MAGC='" + gc.Id + "'";

            return Update(sql);
        }
    }
}
