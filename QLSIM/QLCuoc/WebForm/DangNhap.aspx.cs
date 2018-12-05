using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class DangNhap : System.Web.UI.Page
    {
        QLCuoc 
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCheckPhoneNumber_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtSoDT.Text;
            HOADONDK hoadon = qLCuocDT.HoaDonDKs.Where(x => x.Sim.SoSim == phoneNumber).SingleOrDefault();
            if (hoadon == null)
            {
                CanhBao.Text = "Số điện thoại không tồn tại!";
            }
            else
            {
                Session["NAMECUSTOMER"] = hoadon.KhachHang.TenKH;
                Session["MaSim"] = hoadon.Sim.MaSim.ToString();
                Server.Transfer("MainForm.aspx");
            }
        }
    }
}