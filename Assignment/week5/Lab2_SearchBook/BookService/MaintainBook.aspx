<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaintainBook.aspx.cs" Inherits="BookService.MaintainBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function ClearAllText() {
            document.getElementById('txtBookID').value = '';
            document.getElementById('txtBookTitle').value = '';
            document.getElementById('txtBookPrice').value = '';
            document.getElementById('txtBookQuantity').value = '';
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>BookID</td>
                <td>
                    <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button Id="btnSearch" runat="server" Text="Search By BookID" OnClick="btnSearch_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    BookTitle
                </td>
                <td>
                    <asp:TextBox ID="txtBookTitle" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    BookPrice
                </td>
                <td>
                    <asp:TextBox ID="txtBookPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    BookQuantity
                </td>
                <td>
                    <asp:TextBox ID="txtBookQuantity" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClientClick="return ClearAllText()"/>
        
        <asp:GridView ID="gvBookList" runat="server" OnSelectedIndexChanging="gvBookList_SelectedIndexChanging" AutoGenerateSelectButton="true" EmptyDataText="Book not found"></asp:GridView>
    </form>
</body>
</html>
