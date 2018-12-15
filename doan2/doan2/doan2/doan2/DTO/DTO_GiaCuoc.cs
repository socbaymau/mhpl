using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DTO
{
    public class DTO_GiaCuoc
    {
        private string id;
        private string _thoigianbatdau;
        private string _giacuoc;
        private string _thoigianketthuc;

        public string thoigianbatdau { get => _thoigianbatdau; set => _thoigianbatdau = value; }
        public string thoigiankethuc { get => _thoigianketthuc; set => _thoigianketthuc = value; }
        public string giacuoc { get => _giacuoc; set => _giacuoc = value; }
        public string Id { get => id; set => id = value; }
    }
}
