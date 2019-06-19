<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageLifeCycle2.aspx.cs" Inherits="_02DemoPageLifeCycle.PageLifeCycle2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="lblName" runat="server" Text="Name : "></asp:Label>
            <asp:Button ID="btnSubmit" runat="server" Text="Button" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
