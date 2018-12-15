using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using doan2.DTO;
using doan2.BUS;

namespace doan2.GUI
{
    public partial class GUI_filelog : DevExpress.XtraEditors.XtraForm
    {
        public GUI_filelog()
        {
            InitializeComponent();
        }
        BUS_CTSD bctsd = new BUS_CTSD();
        private void GUI_filelog_Load(object sender, EventArgs e)
        {
            loaddulieu();
        }
        public void loaddulieu()
        {            
                FileStream fs = new FileStream("E:\\test.txt", FileMode.Open, FileAccess.Read, FileShare.None);
                System.IO.StreamReader file = new System.IO.StreamReader(fs);
                string[] columnnames = file.ReadLine().Split('\t');
                DataTable dt = new DataTable();
                foreach (string c in columnnames)
                {
                    dt.Columns.Add(c);
                }

               // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                string newline;
                while ((newline = file.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    string[] values = newline.Split('\t');
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }

                    dt.Rows.Add(dr);
                }
                file.Close();
                dataGridView1.DataSource = dt;
            
        }

        int TinhCuoc(DateTime TGBD, DateTime TGKT, int sophut)
        {
            DateTime d1 = new DateTime(TGBD.Year, TGBD.Month, TGBD.Day, 23, 0, 0);
            DateTime d2 = new DateTime(TGBD.Year, TGBD.Month, TGBD.Day, 7, 0, 0);
            TimeSpan sp1, sp2;
            int giacuoc = 0, tmp1, tmp2;
            if (TGBD.Hour >= 7 && TGBD.Hour < 23 && TGKT.Hour >= 7 && TGKT.Hour < 23)
            {
                giacuoc = sophut * 200;
            }
            else if ((TGBD.Hour > 22 || TGBD.Hour < 7) && (TGKT.Hour > 22 || TGKT.Hour < 7))
            {
                giacuoc = sophut * 150;
            }
            else if (TGBD.Hour >= 7 && TGBD.Hour <= 23)
            {
                sp1 = d1 - TGBD;
                sp2 = TGKT - d1;
                tmp1 = sp1.Hours * 60 + sp1.Minutes + 1;
                tmp2 = sp2.Hours * 60 + sp2.Minutes;
                giacuoc = tmp1 * 200 + tmp2 * 150;
            }
            else
            {
                sp1 = d2 - TGBD;
                sp2 = TGKT - d2;
                tmp1 = sp1.Hours * 60 + sp1.Minutes + 1;
                tmp2 = sp2.Hours * 60 + sp2.Minutes;
                giacuoc = tmp1 * 150 + tmp2 * 200;

            }
            return giacuoc;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {

            bctsd.Delete_CTSD();
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    
                    string id_sim = dataGridView1.Rows[i].Cells["IDSIM"].Value.ToString();
                    DateTime Tgbd = DateTime.Parse(dataGridView1.Rows[i].Cells["TGBD"].Value.ToString());
                    DateTime Tgkt = DateTime.Parse(dataGridView1.Rows[i].Cells["TGKT"].Value.ToString());
                    DateTime TGBD = DateTime.Parse(dataGridView1.Rows[i].Cells["TGBD"].Value.ToString());
                    DateTime TGKT = DateTime.Parse(dataGridView1.Rows[i].Cells["TGKT"].Value.ToString());

                    TimeSpan tmp = TGKT - TGBD;
                    int sophut = tmp.Hours * 60 + tmp.Minutes;
                    int Sophutsudung = sophut;
                    int Cuocphi = TinhCuoc(TGBD, TGKT, sophut);
                    //ctsd.ID = maxid;
                    DTO_CTSD ctsd = new DTO_CTSD(id_sim,Tgbd,Tgkt,Sophutsudung,Cuocphi);
                bctsd.Insert_ctsd(ctsd);
                
            }
        }
    }
}