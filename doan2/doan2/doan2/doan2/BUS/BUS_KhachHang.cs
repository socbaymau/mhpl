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
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_kh = new DAL_KhachHang();
        
        public DataTable getall_kh()
        {
            return dal_kh.getall();
        }
        public DataTable Search_KH( string s)
        {
            return dal_kh.Search(s);
        }
        public bool Insert_KH(DTO_KhachHang dto_kh)
        {
            return dal_kh.insert_kh(dto_kh);
        }
        public bool Update_KH(DTO_KhachHang dto_kh)
        {
            return dal_kh.update_kh(dto_kh);
        }
        public bool Delete_KH(string s)
        {
            return dal_kh.delete_kh(s);
        }
    }
}
