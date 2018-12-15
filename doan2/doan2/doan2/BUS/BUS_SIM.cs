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
    class BUS_SIM
    {
        DAL_SIM dal_s = new DAL_SIM();
        public bool Insert_Sim(DTO_Sim ds)
        {
            return dal_s.INSERT_SIM(ds);
        }
        public bool Update_Sim(DTO_Sim ds)
        {
            return dal_s.update_sim(ds);
        }
        public DataTable GetAll()
        {
            return dal_s.getall();
        }
        public DataTable Search_Sim(string s)
        {
            return dal_s.search(s);
        }
        public bool Delete_Sim(string s)
        {
            return dal_s.delete_sim(s);
        }
        public DataTable Getall_kh()
        {
            return dal_s.getall_kh();
        }
    }
}
