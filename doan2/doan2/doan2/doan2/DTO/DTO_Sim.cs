using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DTO
{
    public class DTO_Sim
    {
        private string id_sim;
        private string ma_kh;
        private bool tinhtrang;

        public string Id_sim { get => id_sim; set => id_sim = value; }
        public string Ma_kh { get => ma_kh; set => ma_kh = value; }
        public bool Tinhtrang { get => tinhtrang; set => tinhtrang = value; }

        public DTO_Sim(string id_sim , string ma_kh , bool tinhtrang)
        {
            this.Id_sim = id_sim;
            this.Ma_kh = ma_kh;
            this.Tinhtrang = tinhtrang;
        }
    }
}
