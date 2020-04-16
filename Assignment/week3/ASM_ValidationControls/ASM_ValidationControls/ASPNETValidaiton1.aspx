<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPNETValidaiton1.aspx.cs" Inherits="ASM_ValidationControls.ASPNETValidaiton1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <table align="center" cellpadding="5" cellspaicng="0">
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="194px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFeildValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Không để trống bắt buộc">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email không đúng định dạng" ValidationExpression="\w+([+-.']\w+)*@\w+([-.]\w+)*\.\w+([-]\w+)*">@</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Xác nhận Email
                </td>
                <td>

                <asp:TextBox ID="txtXacNhanEmail" runat="server" Width="194px"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtEmail" ControlToValidate="txtXacNhanEmail" Display="Dynamic" ErrorMessage="Xác nhận không giống email">#</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Điểm
                </td>
                <td>
                    <asp:TextBox ID="txtDiem" runat="server" Width="111px"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtDiem" Display="Dynamic" ErrorMessage="Điểm phải từ 0 đến 10" MaximumValue="10" MinimumValue="0" Type="Double">0..10</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    Ngày sinh
                </td>
                <td>
                    <asp:TextBox ID="txtNgaySinh" runat="server" Width="111px"></asp:TextBox>
                    <asp:CompareValidator ID="valNgaySinh" runat="server" ControlToValidate="txtNgaySinh" Display="Dynamic" ErrorMessage="Ngày sinh phải trên 16 tuổi" Operator="LessThan" Type="Date">&gt;16</asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:Button ID="btnKiemLoi" runat="server" Text="Kiểm lỗi" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Vui lòng khắc phục các lỗi sau" ShowMessageBox="true" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
