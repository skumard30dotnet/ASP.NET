<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="UserControl.Login" %>

Login Control:
<br />
<table>
    <tr>
        <td>
            Email :
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Password :
        </td>
        <td>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
                            <asp:Button ID="txtLogin" runat="server" Text="Login"></asp:Button>
        </td>
    </tr>
</table>
