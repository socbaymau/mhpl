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
    public partial class GUI_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        BUS_KhachHang kh = new BUS_KhachHang();
        public GUI_KhachHang()
        {
            InitializeComponent();
        }
        private void loaddata()
        {
            
            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", dg_khachhang.DataSource, "TENKH");
            txt_cmnd.DataBindings.Clear();
            txt_cmnd.DataBindings.Add("Text", dg_khachhang.DataSource, "CMND");
            txt_nghenghiep.DataBindings.Clear();
            txt_nghenghiep.DataBindings.Add("Text", dg_khachhang.DataSource, "NGHENGHIEP");
            txt_chucvu.DataBindings.Clear();
            txt_chucvu.DataBindings.Add("Text", dg_khachhang.DataSource, "CHUCVU");
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dg_khachhang.DataSource, "DIACHI");
            txt_makh.DataBindings.Clear();
            txt_makh.DataBindings.Add("Text", dg_khachhang.DataSource, "EMAIL");

        }
        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            dg_khachhang.DataSource = kh.getall_kh();
            loaddata();
        }

       
        

       

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them1_Click(object sender, EventArgs e)
        {
            if (txt_hoten.Text != " " && txt_cmnd.Text != " ")
            {
                DTO_KhachHang dto_kh = new DTO_KhachHang("0", txt_hoten.Text, txt_cmnd.Text, txt_nghenghiep.Text, txt_chucvu.Text, txt_diachi.Text, txt_makh.Text);
                if (kh.Insert_KH(dto_kh))
                {
                    MessageBox.Show("Thêm Thành Công ");
                    dg_khachhang.DataSource = kh.getall_kh();
                }
                else
                    MessageBox.Show("Thêm Thất Bại");
            }
        }

        private void btn_sua1_Click(object sender, EventArgs e)
        {
            if (dg_khachhang.SelectedRows.Count > 0)
            {
                if (txt_hoten.Text != " " && txt_nghenghiep.Text != " " && txt_diachi.Text != " " && txt_cmnd.Text != " " && txt_chucvu.Text != " ")
                {
                    DTO_KhachHang dto_kh = new DTO_KhachHang(dg_khachhang.CurrentRow.Cells[0].Value.ToString(), txt_hoten.Text, txt_cmnd.Text, txt_nghenghiep.Text, txt_chucvu.Text, txt_diachi.Text, txt_makh.Text);
                    if (kh.Update_KH(dto_kh))
                    {
                        MessageBox.Show("Sửa Thành Công");
                        dg_khachhang.DataSource = kh.getall_kh();
                        loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thất Bại");
                    }
                }
                else { MessageBox.Show("Vui Lòng Nhập Đầy Đủ Thông Tin"); }
            }
            else { MessageBox.Show("Vui Lòng Chọn Khách Hàng Bạn Muốn Sửa "); }
        }

        private void btn_xoa1_Click(object sender, EventArgs e)
        {
            if (dg_khachhang.SelectedRows.Count > 0)
            {
                DialogResult = MessageBox.Show("Bạn Có Chắc Muốn Xóa ID :" + dg_khachhang.CurrentRow.Cells[0].Value.ToString() + " ? ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.OK)
                {
                    if (kh.Delete_KH(dg_khachhang.CurrentRow.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        dg_khachhang.DataSource = kh.getall_kh();
                        loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại ");
                    }
                }
            }
            else { MessageBox.Show("Vui Lòng Chọn Khách Hàng Bạn Muốn Xóa"); }
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            txt_makh.Text = " ";
            txt_chucvu.Text = " ";
            txt_cmnd.Text = " ";
            txt_diachi.Text = " ";
            txt_hoten.Text = " ";
            txt_nghenghiep.Text = " ";
            dg_khachhang.DataSource = kh.getall_kh();
            loaddata();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            if(txt_tk.Text != " ")
            {
                
                    dg_khachhang.DataSource = kh.Search_KH(txt_tk.Text);
               
                    loaddata();
                
            }
        }
    }
}