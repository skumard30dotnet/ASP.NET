<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoUserControl.aspx.cs" Inherits="UserControl.DemoUserControl" %>

<%@ Register Src="~/Login.ascx" TagPrefix="uc1" TagName="Login" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style>

</style>
    <script>

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Login runat="server" ID="Login" bo />
            <uc1:Login runat="server" ID="Login5" />
            <uc1:Login runat="server" ID="Login3" />
            <uc1:Login runat="server" ID="Login4" />
            <uc1:Login runat="server" ID="Login2" />
            <uc1:Login runat="server" ID="Login1" />
           <asp:TextBox ID="" runat="" ></asp:TextBox>
        </div>
    </form>
</body>
</html>
