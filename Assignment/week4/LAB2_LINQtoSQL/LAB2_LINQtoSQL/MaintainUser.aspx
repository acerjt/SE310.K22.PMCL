<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaintainUser.aspx.cs" Inherits="LAB2_LINQtoSQL.MaintainUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
        <table>
            <tr>
                <td>
                    Username
                </td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>  
            <tr>
                <td>
                    BirthDate
                </td>
                <td>
                    <asp:TextBox ID="txtBirthDate" runat="server"></asp:TextBox>
                </td>
            </tr>  
            <tr>
                <td>
                    Address
                </td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div style="margin: 20px 0px;">
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"  />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" style="margin-left:20px"  />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" style="margin-left:20px" />
        </div>
        <asp:GridView ID="gvUserInforList" runat="server" OnSelectedIndexChanging="gvUserInfoList_SelectedIndexChanging" AutoGenerateSelectButton="true"></asp:GridView>
    </form>
</body>
</html>
