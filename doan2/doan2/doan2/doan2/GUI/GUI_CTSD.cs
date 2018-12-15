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
using doan2.DAL;
using doan2.DTO;
using System.Collections;
using doan2.BUS;

namespace doan2.GUI
{
    public partial class GUI_CTSD : DevExpress.XtraEditors.XtraForm
    {
        public GUI_CTSD()
        {
            InitializeComponent();
        }
        BUS_CTSD bctsd = new BUS_CTSD();
        public bool ExistForm(XtraForm Form)
        {


            if (MdiChildren.Count() > 0)
            {
                foreach (var child in MdiChildren)
                {
                    if (child.Name == Form.Name)
                    {
                        child.Activate();
                        return true;
                    }

                }
            }
            return false;
        }
        public string FileName { get; private set; }
        DataTable idsim;
       

        private void GUI_CTSD_Load(object sender, EventArgs e)
        {
            //cb_sim.DataSource = bctsd.get_sim();
            //cb_sim.DisplayMember = "IDSIM";

            dataGridView1.DataSource = bctsd.List_all();
            //Loaddata();
           // DAL_CTSD dct = new DAL_CTSD();

           // idsim = dct.getID();
            
           //// object[] row = idsim.Rows.ToString();
           //     for(int i=0;i<5;i++)
           //     MessageBox.Show(idsim.Rows[i][0].ToString());
        }

        private void btn_rd_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(2017, 1, 1);
            int range = (DateTime.Today - start).Days;
            int j = 0;
            Random a = new Random();

            FileStream fs = new FileStream("E:\\test.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sWriter = new StreamWriter(fs, Encoding.UTF8);
            sWriter.WriteLine("IDSIM\tTGBD\tTGKT");
            idsim = bctsd.get_sim();
            for (int i = 1; i <= 100; i++)
            {
                j++;
                if (idsim.Rows.Count - 1 < j)
                {
                    j = 0;
                }
                string id = idsim.Rows[j][0].ToString();
                int b = a.Next(7);
                int c = a.Next(59);
                TimeSpan d = new System.TimeSpan(0, b, c, 0);
                DateTime TGBD = start.AddDays(a.Next(range)).AddHours(a.Next(0, 23)).AddMinutes(a.Next(0, 60)).AddSeconds(a.Next(0, 60));

                DateTime TGKT = TGBD.Add(d);
                sWriter.WriteLine(id + "\t" + TGBD.ToString("yyyy-MM-dd HH:mm:ss") + "\t" + TGKT.ToString("yyyy-MM-dd HH:mm:ss"));


            }
            sWriter.Flush();


            fs.Close();
            GUI_filelog form = new GUI_filelog();
            if (ExistForm(form)) return;
           // form.MdiParent = this.MdiParent;
            form.Show();

        }
        //public void Loaddata()
        //{
            
        //    txt_ma.DataBindings.Clear();
        //    txt_ma.DataBindings.Add("Text", dataGridView1.DataSource, "IDCTSD");
        //    cb_sim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    txt_spsd.DataBindings.Clear();
        //    txt_spsd.DataBindings.Add("Text", dataGridView1.DataSource, "SOPHUTSD");
        //    txt_cp.DataBindings.Clear();
        //    txt_cp.DataBindings.Add("Text", dataGridView1.DataSource, "CUOCPHI");
        //    dt_tgbd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //    dt_tgkt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        //}

        //private void btn_them_Click(object sender, EventArgs e)
        //{
        //    DateTime td = DateTime.Parse(dt_tgbd.Text);
        //    DateTime tt = DateTime.Parse(dt_tgkt.Text);
        //    DTO_CTSD dcs = new DTO_CTSD(cb_sim.Text, td, tt, Convert.ToInt16(txt_spsd.Text), Convert.ToInt16(txt_cp.Text));
        //    bctsd.Insert_ctsd(dcs);
        //    dataGridView1.DataSource = bctsd.List_all();
        //    Loaddata();
        //}

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = bctsd.List_all();
            //Loaddata();
            //txt_cp.Text = " ";
            //txt_ma.Text = " ";
            //txt_spsd.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_tk.Text != " ")
            {
                dataGridView1.DataSource = bctsd.Search(txt_tk.Text);
                //Loaddata();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Loaddata();
        }
    }
}