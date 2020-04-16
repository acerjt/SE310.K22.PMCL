<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="DangKy.DangKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
            <div>

            </div>
            <table align="center" cellpadding="5" cellspacing="0">
                <tr>
                    <h1>Phiếu Đăng Ký Thành Viên Diễn Đàn Tin Học</h1>
                </tr>
                <tr>
                    <td>Tên đăng nhập</td>
                    <td>
                        <asp:TextBox ID="txtTenDangNhap" runat="server" Width="194px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="txtTenDangNhap" Display="Dynamic" ErrorMessage="Bạn phải nhập tên !"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Tuổi</td>
                    <td>
                        <asp:TextBox ID="txtTuoi" runat="server" Width="194px"></asp:TextBox>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtTuoi"
                            Display="Dynamic" ErrorMessage="18 <= tuổi <= 40" MaximumValue="40" MinimumValue="18"
                            Type="Integer"></asp:RangeValidator>  
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                            ControlToValidate="txtTuoi" Display="Dynamic" ErrorMessage="Tuổi không được để trống"></asp:RequiredFieldValidator>
                        
                    </td>
                </tr>
                <tr>
                    <td>Mật khẩu</td>
                    <td>
                        <asp:TextBox ID="txtMatKhau" runat="server" Width="111px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                            ControlToValidate="txtMatKhau" Display="Dynamic" ErrorMessage="Mật khẩu phải được nhập"></asp:RequiredFieldValidator>
                        
                    </td>
                </tr>
                <tr>
                    <td>Nhập lại mật khẩu</td>
                    <td>
                        <asp:TextBox ID="txtNhapLaiMatKhau" runat="server" Width="111px"></asp:TextBox>
                        
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="txtNhapLaiMatKhau" Display="Dynamic" ErrorMessage="Bạn phải nhập lại mật khẩu !"></asp:RequiredFieldValidator>   
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNhapLaiMatKhau" ControlToValidate="txtMatKhau"
                            Display="Dynamic" ErrorMessage="Mật khẩu không hợp lệ"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" Width="194px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                            ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email không hợp lệ"></asp:RequiredFieldValidator>
                        
                        <asp:RegularExpressionValidator  ID="RegularExpressionValidator1" runat="server"
                            ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email Không hợp lệ" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp</td>
                    <td>
                        <asp:Button ID="btnKiemLoi" runat="server" Text="Kiểm tra"/>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp</td>
                    <td>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Vui lòng khắc phục các lỗi sau" ShowMessageBox="true"/>
                    </td>
                </tr>
            </table>
        </form>
</body>
</html>
