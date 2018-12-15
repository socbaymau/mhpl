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
    class BUS_HDDK
    {
        DAL_HDDK DalHDDK = new DAL_HDDK();
        public DataTable getAll()
        {
            return DalHDDK.getAll();
        }
        public bool Insert(DTO_HoaDonDangKy hd)
        {
            return DalHDDK.insert(hd);
        }
        public DataTable Search_Sim(string s)
        {
            return DalHDDK.search(s);
        }
        public DataTable Get_IDSIM()
        {
            return DalHDDK.get_idsim();
        }
    }
}
