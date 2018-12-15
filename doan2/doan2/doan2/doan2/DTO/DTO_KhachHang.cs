using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DTO
{
    public class DTO_KhachHang
    {
        private string _makh;
        private string _hoten;
        private string _cmnd;
        private string _diachi;
        private string _chucvu;
        private string _nghenghiep;
        private string _email;

        public string makh { get => _makh; set => _makh = value; }
        public string hoten { get => _hoten; set => _hoten = value; }
        public string cmnd { get => _cmnd; set => _cmnd = value; }
        public string diachi { get => _diachi; set => _diachi = value; }
        public string chucvu { get => _chucvu; set => _chucvu = value; }
        public string nghenghiep { get => _nghenghiep; set => _nghenghiep = value; }
        public string email { get => _email; set => _email = value; }
        public DTO_KhachHang( string _makh, string _hoten, string _cmnd, string _nghenghiep, string _chucvu, string _diachi,string _email)
        {
            this.makh = _makh;
            this.hoten = _hoten;
            this.cmnd = _cmnd;
            this.nghenghiep = _nghenghiep;
            this.chucvu = _chucvu;
            this.diachi = _diachi;
            this.email = _email;
        }
    }
}
