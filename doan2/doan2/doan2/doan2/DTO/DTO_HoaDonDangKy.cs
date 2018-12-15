using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DTO
{
    class DTO_HoaDonDangKy
    {
        private int ma_hddk;
        private string ma_kh;
        private DateTime ngay;
        private long phihoamang;

        public int Ma_hddk { get => ma_hddk; set => ma_hddk = value; }      
        public string Ma_kh { get => ma_kh; set => ma_kh = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
        public long Phihoamang { get => phihoamang; set => phihoamang = value; }

        
    }
}
