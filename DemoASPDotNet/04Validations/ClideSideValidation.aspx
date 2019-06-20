<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClideSideValidation.aspx.cs" Inherits="_04Validations.ClideSideValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtEmployeeName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFVEmployeeName" runat="server" ErrorMessage="Please enter Employee Name" ControlToValidate="txtEmployeeName"></asp:RequiredFieldValidator>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
