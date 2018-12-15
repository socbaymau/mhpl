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
using doan2.BUS;
using doan2.DTO;

namespace doan2.GUI
{
    public partial class GUI_HoaDonDangKy : DevExpress.XtraEditors.XtraForm
    {
        BUS_HDDK bushddk = new BUS_HDDK();
        public GUI_HoaDonDangKy()
        {
            InitializeComponent();
        }

        private void GUI_HoaDonDangKy_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            dgvhddk.DataSource = bushddk.getAll();
            cb_sim.DataSource = bushddk.Get_IDSIM();
            cb_sim.DisplayMember = "IDSIM";
            cb_sim.ValueMember = "IDSIM";
        }
        

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
                dgvhddk.DataSource = bushddk.Search_Sim(txtTimKiem.Text);
            else
                loaddata();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DTO_HoaDonDangKy dtohddk = new DTO_HoaDonDangKy();
            dtohddk.Ma_kh = cb_sim.SelectedValue.ToString();
            dtohddk.Phihoamang = int.Parse(txtPhi.Text);
            dtohddk.Ngay = DateTime.Now;
            if (bushddk.Insert(dtohddk))
                MessageBox.Show("Thêm Thành Công");
            else
                MessageBox.Show("Thêm Thất Bại");
            loaddata();
        }
    }
}