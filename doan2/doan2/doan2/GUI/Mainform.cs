using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;
using doan2.GUI;

namespace doan2
{
    public partial class Mainform : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public Mainform()
        {
            InitializeComponent();
        }
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
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            GUI_SIM form = new GUI_SIM();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_KhachHang form = new GUI_KhachHang();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_GiaCuoc form = new GUI_GiaCuoc();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_CTSD form = new GUI_CTSD();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_HoaDonTinhcuoc form = new GUI_HoaDonTinhcuoc();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            XtraTabbedMdiManager mdiManager = new XtraTabbedMdiManager();
            mdiManager.MdiParent = this;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GUI_HoaDonDangKy form = new GUI_HoaDonDangKy();
            if (ExistForm(form)) return;
            form.MdiParent = this;
            form.Show();
        }
    
    }
}
