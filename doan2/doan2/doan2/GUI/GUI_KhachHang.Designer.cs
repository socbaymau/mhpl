namespace doan2.GUI
{
    partial class GUI_KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_KhachHang));
            this.dg_khachhang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.txt_nghenghiep = new System.Windows.Forms.TextBox();
            this.txt_chucvu = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_refesh = new DevExpress.XtraEditors.SimpleButton();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.btn_tk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_khachhang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_khachhang
            // 
            this.dg_khachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_khachhang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_khachhang.Location = new System.Drawing.Point(103, 260);
            this.dg_khachhang.Name = "dg_khachhang";
            this.dg_khachhang.Size = new System.Drawing.Size(699, 189);
            this.dg_khachhang.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.txt_cmnd);
            this.groupBox1.Controls.Add(this.txt_nghenghiep);
            this.groupBox1.Controls.Add(this.txt_chucvu);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_makh);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 146);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(125, 31);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(177, 21);
            this.txt_hoten.TabIndex = 24;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(125, 119);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(177, 21);
            this.txt_cmnd.TabIndex = 23;
            // 
            // txt_nghenghiep
            // 
            this.txt_nghenghiep.Location = new System.Drawing.Point(516, 31);
            this.txt_nghenghiep.Name = "txt_nghenghiep";
            this.txt_nghenghiep.Size = new System.Drawing.Size(177, 21);
            this.txt_nghenghiep.TabIndex = 22;
            // 
            // txt_chucvu
            // 
            this.txt_chucvu.Location = new System.Drawing.Point(516, 74);
            this.txt_chucvu.Name = "txt_chucvu";
            this.txt_chucvu.Size = new System.Drawing.Size(177, 21);
            this.txt_chucvu.TabIndex = 21;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(516, 115);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(177, 21);
            this.txt_diachi.TabIndex = 20;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(125, 70);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(177, 21);
            this.txt_makh.TabIndex = 19;
            this.txt_makh.TextChanged += new System.EventHandler(this.txt_makh_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(41, 121);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 19);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "CMND :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(384, 33);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(113, 19);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Nghề nghiệp :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(384, 76);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 19);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Chức vụ :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(384, 117);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 19);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Địa chỉ :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(41, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 19);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Email :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 19);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Họ Tên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "KHÁCH HÀNG";
            // 
            // btn_them1
            // 
            this.btn_them1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them1.Appearance.Options.UseFont = true;
            this.btn_them1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_them1.Location = new System.Drawing.Point(103, 203);
            this.btn_them1.Name = "btn_them1";
            this.btn_them1.Size = new System.Drawing.Size(94, 51);
            this.btn_them1.TabIndex = 20;
            this.btn_them1.Text = "Thêm";
            this.btn_them1.Click += new System.EventHandler(this.btn_them1_Click);
            // 
            // btn_sua1
            // 
            this.btn_sua1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua1.Appearance.Options.UseFont = true;
            this.btn_sua1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btn_sua1.Location = new System.Drawing.Point(223, 203);
            this.btn_sua1.Name = "btn_sua1";
            this.btn_sua1.Size = new System.Drawing.Size(94, 51);
            this.btn_sua1.TabIndex = 21;
            this.btn_sua1.Text = "Sửa";
            this.btn_sua1.Click += new System.EventHandler(this.btn_sua1_Click);
            // 
            // btn_xoa1
            // 
            this.btn_xoa1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa1.Appearance.Options.UseFont = true;
            this.btn_xoa1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image1")));
            this.btn_xoa1.Location = new System.Drawing.Point(342, 203);
            this.btn_xoa1.Name = "btn_xoa1";
            this.btn_xoa1.Size = new System.Drawing.Size(94, 51);
            this.btn_xoa1.TabIndex = 22;
            this.btn_xoa1.Text = "Xóa";
            this.btn_xoa1.Click += new System.EventHandler(this.btn_xoa1_Click);
            // 
            // btn_refesh
            // 
            this.btn_refesh.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refesh.Appearance.Options.UseFont = true;
            this.btn_refesh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image2")));
            this.btn_refesh.Location = new System.Drawing.Point(464, 203);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(119, 51);
            this.btn_refesh.TabIndex = 23;
            this.btn_refesh.Text = "Làm mới";
            this.btn_refesh.Click += new System.EventHandler(this.btn_refesh_Click);
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(623, 221);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(145, 21);
            this.txt_tk.TabIndex = 24;
            // 
            // btn_tk
            // 
            this.btn_tk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tk.Location = new System.Drawing.Point(774, 219);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(75, 23);
            this.btn_tk.TabIndex = 25;
            this.btn_tk.Text = "Tìm kiếm";
            this.btn_tk.UseVisualStyleBackColor = true;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(619, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tìm kiếm theo MaKH hoặc CMND";
            // 
            // GUI_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_tk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.btn_refesh);
            this.Controls.Add(this.btn_xoa1);
            this.Controls.Add(this.btn_sua1);
            this.Controls.Add(this.btn_them1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dg_khachhang);
            this.Name = "GUI_KhachHang";
            this.Text = "GUI_KhachHang";
            this.Load += new System.EventHandler(this.GUI_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_khachhang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dg_khachhang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.TextBox txt_nghenghiep;
        private System.Windows.Forms.TextBox txt_chucvu;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_makh;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_them1;
        private DevExpress.XtraEditors.SimpleButton btn_sua1;
        private DevExpress.XtraEditors.SimpleButton btn_xoa1;
        private DevExpress.XtraEditors.SimpleButton btn_refesh;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button btn_tk;
        private System.Windows.Forms.Label label2;
    }
}