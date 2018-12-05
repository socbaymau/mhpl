<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="WebForm.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h3 style="background-color:cornflowerblue;">Tra cứu thông tin</h3>
           <table>
               <tbody>
                   <tr>
                       <td style="text-align: center">
                           <span class="Label">Nhập số điện thoại</span>
                       </td>
                       <td>
                           <asp:TextBox CssClass="form-control" runat="server" ID="txtSoDT"></asp:TextBox>
                       </td>
                   </tr>
                   <tr>
                       <asp:Label runat="server" BackColor="#ff0000" ID="CanhBao" Text=""></asp:Label>
                   </tr>
                   <tr>
                       <td class="Left" style="text-align:center">
                           <asp:Button runat="server" CssClass="btn btn-info" OnClick="btnClick" ID="btnCheck" Text="OK" />
                       </td>
                   </tr>
               </tbody>
           </table>
        </div>
    </form>
</body>
</html>
