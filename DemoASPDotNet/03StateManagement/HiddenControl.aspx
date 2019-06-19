<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenControl.aspx.cs" Inherits="_03StateManagement.HiddenControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="HiddenField1" runat="server"  />  
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" EnableViewState="False"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
