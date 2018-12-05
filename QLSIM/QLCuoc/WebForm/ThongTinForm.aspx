<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ThongTinForm.aspx.cs" Inherits="WebForm.ThongTinForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <table>
                <tr>
                    <td>Tên khách hàng</td>
                    <td><asp:Label runat="server" ID="txtName"></asp:Label></td>
                </tr>
                <tr>
                    <td>Từ ngày</td>
                    <td>
                        <asp:TextBox ID="FromDate" CssClass="form-control" placeholder="Từ ngày" runat="server"></asp:TextBox>
                                    <script type="text/javascript">
                                        var pickerFrom = new Pikaday(
                                            {
                                                field: document.getElementById('FromDate'),
                                                firstDay: 1,
                                                format: 'D/M/YYYY',
                                                minDate: new Date('2010-01-01'),
                                                maxDate: new Date('2020-12-31'),
                                                yearRange: [2010, 2020],
                                                numberOfMonths: 1,
                                                theme: 'blue-theme',
                                                toString(date, format) {
                                                    // you should do formatting based on the passed format,
                                                    // but we will just return 'D/M/YYYY' for simplicity
                                                    const day = date.getDate();
                                                    const month = date.getMonth() + 1;
                                                    const year = date.getFullYear();
                                                    return `${day}/${month}/${year}`;
                                                },
                                                parse(dateString, format) {
                                                    // dateString is the result of `toString` method
                                                    const parts = dateString.split('/');
                                                    const day = parseInt(parts[0], 10);
                                                    const month = parseInt(parts[1], 10) - 1;
                                                    const year = parseInt(parts[2], 10);
                                                    return new Date(year, month, day);
                                                }
                                            });
                                    </script>
                    </td>
                </tr>
                <tr>
                    <td>Đến ngày</td>
                    <td>
                        <asp:TextBox ID="ToDate" CssClass="form-control" placeholder="Đến ngày" runat="server"></asp:TextBox>
                                    <script type="text/javascript">
                                        var pickerTo = new Pikaday(
                                            {
                                                field: document.getElementById('ToDate'),
                                                firstDay: 1,
                                                format: 'D/M/YYYY',
                                                minDate: new Date('2000-01-01'),
                                                maxDate: new Date('2020-12-31'),
                                                yearRange: [2000, 2020],
                                                numberOfMonths: 1,
                                                theme: 'dark-theme',
                                                toString(date, format) {
                                                    // you should do formatting based on the passed format,
                                                    // but we will just return 'D/M/YYYY' for simplicity
                                                    const day = date.getDate();
                                                    const month = date.getMonth() + 1;
                                                    const year = date.getFullYear();
                                                    return `${day}/${month}/${year}`;
                                                },
                                                parse(dateString, format) {
                                                    // dateString is the result of `toString` method
                                                    const parts = dateString.split('/');
                                                    const day = parseInt(parts[0], 10);
                                                    const month = parseInt(parts[1], 10) - 1;
                                                    const year = parseInt(parts[2], 10);
                                                    return new Date(year, month, day);
                                                }
                                            });
                                    </script>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>