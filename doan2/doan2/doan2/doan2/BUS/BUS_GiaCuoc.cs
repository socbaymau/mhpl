using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using doan2.DAL;
using doan2.DTO;

namespace doan2.BUS
{
    class BUS_GiaCuoc
    {
        DAL_GiaCuoc GC = new DAL_GiaCuoc();
        public DataTable getAll()
        {
            return GC.getAll();
        }
        public bool update(DTO_GiaCuoc gc)
        {
            return GC.update_kh(gc);
        }
    }
}
