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
    public partial class GUI_SIM : DevExpress.XtraEditors.XtraForm
    {
        BUS_SIM bs = new BUS_SIM();
        public GUI_SIM()
        {
            InitializeComponent();
        }
        public void load()
        {
            txt_id.DataBindings.Clear();
            txt_id.DataBindings.Add("Text",dataGridView1.DataSource, "IDSIM");
            comboBox2.DataBindings.Clear();
            comboBox2.DataBindings.Add("Text", dataGridView1.DataSource, "MAKH");
            
            //comboBox1.DataBindings.Add("Text", dataGridView1.DataSource, "TRINHTRANG");
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "True") comboBox1.Text = "Kích Hoạt";
            else comboBox1.Text = "Khóa";

        }
        public void cbb_kh()
        {
            comboBox2.DataSource = bs.Getall_kh();
            comboBox2.DisplayMember = "MAKH";
            comboBox2.ValueMember = "MAKH";
        }
        private void SIM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSIMDTDataSet.THONGTINSIM' table. You can move, or remove it, as needed.
            this.tHONGTINSIMTableAdapter.Fill(this.qLSIMDTDataSet.THONGTINSIM);
            cbb_kh();
            comboBox1.Items.Add("Kích Hoạt");
            comboBox1.Items.Add("Khóa");
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = bs.GetAll();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool tt = false;
            if(txt_id.Text != " " && comboBox2.SelectedValue.ToString() != " ")
            {
                if (comboBox1.SelectedItem.ToString() == "Kích Hoạt")
                {
                    tt = true;
                }
                DTO_Sim ds = new DTO_Sim(txt_id.Text, comboBox2.SelectedValue.ToString(), tt);
                if (bs.Insert_Sim(ds))
                {
                    MessageBox.Show("Thêm Thành Công ");
                    dataGridView1.DataSource = bs.GetAll();
                }
                else { MessageBox.Show("Thêm Thất Bại"); }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult = MessageBox.Show("Bạn có chắc muốn xóa ID = " + txt_id.Text, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(DialogResult == DialogResult.OK)
                {
                    if (bs.Delete_Sim(txt_id.Text))
                    {
                        MessageBox.Show("Xóa Thành Công ");
                        
                    }else { MessageBox.Show("Xóa Thất Bại "); }
                }
            }
            else { MessageBox.Show("Vui lòng chọn Sim muốn xóa "); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if(txt_timkiem.Text != " ")
            {
                dataGridView1.DataSource = bs.Search_Sim(txt_timkiem.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_id.Text = " ";
            dataGridView1.DataSource = bs.GetAll();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}