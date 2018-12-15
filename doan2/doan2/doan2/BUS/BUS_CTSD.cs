using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using doan2.DAL;
using doan2.DTO;
using System.Data;

namespace doan2.BUS
{
    class BUS_CTSD
    {
        DAL_CTSD dalcs = new DAL_CTSD();
        public bool Insert_ctsd(DTO_CTSD dcs)
        {
            return dalcs.Insert_CTSD(dcs);
        }
        public DataTable List_all()
        {
            return dalcs.listall();
        }
        public DataTable get_sim()
        {
            return dalcs.getID();
        }
        public DataTable Search(string s)
        {
            return dalcs.search(s);
        }
    }
}
