using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DTO
{
    class DTO_DotCuoc
    {
        private int dotCuoc;
        private DateTime ngayBD;
        private DateTime ngayKT;

        public int DotCuoc { get => dotCuoc; set => dotCuoc = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
    }
}
