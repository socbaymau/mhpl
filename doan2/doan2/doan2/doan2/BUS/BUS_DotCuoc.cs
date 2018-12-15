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
    class BUS_DotCuoc
    {
        DAL_DotCuoc daldotcuoc = new DAL_DotCuoc();
        public DTO_DotCuoc getdotcuoc()
        {
            DTO_DotCuoc dc = new DTO_DotCuoc();
            DataTable dt = daldotcuoc.getDotCuocCuoi();
            dc.DotCuoc = int.Parse( dt.Rows[0][0].ToString());
            dc.NgayBD = DateTime.Parse(dt.Rows[0][1].ToString());
            dc.NgayKT= DateTime.Parse(dt.Rows[0][2].ToString());
            return dc;
        }
    }
}
