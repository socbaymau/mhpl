using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DTO
{
    class DTO_HoaDonDangKy
    {
        private string ma_hddk;
        private string ma_kh;
        private string ngay;
        private string phihoamang;

        public string Ma_hddk { get => ma_hddk; set => ma_hddk = value; }      
        public string Ma_kh { get => ma_kh; set => ma_kh = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public string Phihoamang { get => phihoamang; set => phihoamang = value; }

        
    }
}
