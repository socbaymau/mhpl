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
    class DAL_DotCuoc:DBconnect
    {
        string table = "DOTCUOC";
        public DataTable getDotCuocCuoi()
        {
            string sql = "select top(1) * from DOTCUOC ORDER BY dotcuoc DESC";
            return GetData(sql);
        }
        public bool insert(DTO_DotCuoc dc)
        {
            string sql = "insert into " + table + " values("+dc.DotCuoc +",' " +dc.NgayBD + "','" + dc.NgayKT + "')";
            return Update(sql);
        }
    }
}
