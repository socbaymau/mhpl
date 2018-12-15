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
using System.Net.Mail;
using System.Net;

namespace doan2.GUI
{
    public partial class GUI_HoaDonTinhcuoc : DevExpress.XtraEditors.XtraForm
    {
        BUS_HDCT bushdct = new BUS_HDCT();
        BUS_CTSD busctsd = new BUS_CTSD();
        DTO_DotCuoc dtodotcuoc = new DTO_DotCuoc();
        BUS_DotCuoc busdotcuoc = new BUS_DotCuoc();
        public GUI_HoaDonTinhcuoc()
        {
            InitializeComponent();
            dtodotcuoc = busdotcuoc.getdotcuoc();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loaddata()
        {
            dtodotcuoc = busdotcuoc.getdotcuoc();
            lblngay.Text = "*Tính đến " + dtodotcuoc.NgayKT.ToString("dd.MM.yyyy");
            dgvHD.DataSource = bushdct.getall_kh();
        }
        private void GUI_HoaDonTinhcuoc_Load(object sender, EventArgs e)
        {
            // DTO_DotCuoc dtodotcuoc = busdotcuoc.getdotcuoc();
            dgvHD.DataSource = bushdct.getall_kh();
            lblngay.Text = "*Tính đến " + dtodotcuoc.NgayKT.ToString("dd.MM.yyyy");
            dtpNgayTinh.Text = DateTime.Today.ToString();
        }
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow RW in dgvHD.SelectedRows)
            {
                //MessageBox.Show(RW.Cells[3].Value.ToString());
                //String a= RW.Cells[1].Value.ToString();
                dgvCT.DataSource = busctsd.get_IDSIM(RW.Cells[1].Value.ToString());
                txtID.Text = RW.Cells[0].Value.ToString();
                txtSIM.Text = RW.Cells[1].Value.ToString();
                txtNgay.Text = RW.Cells[4].Value.ToString();
                txtTien.Text = RW.Cells[2].Value.ToString();
                if (RW.Cells[3].Value.ToString() == "True")
                {
                    //MessageBox.Show(RW.Cells[3].Value.ToString());
                    txtTT.Text = "Đã Thanh Toán";
                    btnThanhToan.Enabled = false;
                }
                else
                {
                    txtTT.Text = "Chưa Thanh Toán";
                    btnThanhToan.Enabled = true;
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            bushdct.ThanhToan(int.Parse(txtID.Text));
            MessageBox.Show("Thanh Toán Thành Công");
            btnThanhToan.Enabled = false;
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                dgvHD.DataSource = bushdct.timkiemSIM(txtTimKiem.Text);
            }
            else
            {
                dgvHD.DataSource = bushdct.getall_kh();
            }
        }
        DataTable data;
        private void btnTinhCuoc_Click(object sender, EventArgs e)
        {
            //data = bushdct.GetdatabyID();
            DialogResult dialogResult = MessageBox.Show("Bạn muốn tính cước từ " + dtodotcuoc.NgayKT.AddDays(1).ToString("dd-MM-yyyy") + " đến " + dtpNgayTinh.Value.ToString("dd-MM-yyyy") + "không?", "Xác Nhập", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                //for(int i=0;i< data.Rows.Count;i++)
                //guimail(data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString(), data.Rows[i][3].ToString(),);
                if (dtpNgayTinh.Value < DateTime.Today)
                {
                    bushdct.insert(dtodotcuoc.NgayKT.AddDays(1), dtpNgayTinh.Value, dtodotcuoc);
                    MessageBox.Show("Thành Công");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }
        void guimail(string id ,string makh, string sdt , string tien)
        {
            string nd = "MaHD :"+id+"     MaKH:"+makh+"  Số Điện Thoại :" +sdt+"    Tổng Tiền:"+tien ;
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                                // tài khoản gmail  , password gmail
                mailclient.Credentials = new NetworkCredential("", "");
                // gmail người gửi , gmail người nhận
                MailMessage message = new MailMessage("", "");
                message.Subject = "Hóa Đơn Tiền Cước";
                message.Body = nd;

                mailclient.Send(message);
                MessageBox.Show("Mail đã được gửi đi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}