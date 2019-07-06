<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserViewList.aspx.cs" Inherits="Web.UserViewList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server">

            </asp:GridView>

            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
            <asp:GridView ID="GridView3" runat="server"></asp:GridView>

            <table>
                <thead>

                </thead>
                <tr>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
