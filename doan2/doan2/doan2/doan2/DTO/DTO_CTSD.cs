using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan2.DTO
{
    public class DTO_CTSD
    {

        private string id_sim;
        private DateTime tgbd;
        private DateTime tgkt;
        private int sophutsudung;
        private int cuocphi;



        
        public DTO_CTSD(string id_sim, DateTime tgbd, DateTime tgkt, int sophutsudung, int cuocphi)
        {
            Id_sim = id_sim;
            Tgbd = tgbd;
            Tgkt = tgkt;
            Sophutsudung = sophutsudung;
            Cuocphi = cuocphi;
        }

        public string Id_sim { get => id_sim; set => id_sim = value; }
        public DateTime Tgbd { get => tgbd; set => tgbd = value; }
        public DateTime Tgkt { get => tgkt; set => tgkt = value; }
        public int Sophutsudung { get => sophutsudung; set => sophutsudung = value; }
        public int Cuocphi { get => cuocphi; set => cuocphi = value; }
    }
}
