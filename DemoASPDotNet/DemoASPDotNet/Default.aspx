<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoASPDotNet.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           First Name : <br />
            <asp:TextBox ID="txtFirstName" runat="server" BackColor="#FFCCFF" BorderColor="#000066"  BorderStyle="Groove" BorderWidth="2px" Font-Bold="True" Font-Italic="True" ForeColor="Maroon" MaxLength="10" ToolTip="Enter First Name" Width="200px"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label><br />
            <asp:TextBox ID="txtLastName" runat="server" TabIndex="1"></asp:TextBox>
            <br /><br />
            Country : <br /> <br />
            <asp:DropDownList ID="ddlCountry" runat="server" >
              <%--  <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>China</asp:ListItem>
                <asp:ListItem Enabled="false">Russia</asp:ListItem>--%>
            </asp:DropDownList>
            <br /><br />
            <asp:DropDownList ID="ddlState" runat="server"></asp:DropDownList>
            <br /><br />
            Customers:<br />
            <asp:DropDownList ID="ddlCustomer" runat="server" DataSourceID="SqlDataSource1" DataTextField="ContactName" DataValueField="CustomerID" AutoPostBack="True" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [CustomerID], [ContactName] FROM [Customers]"></asp:SqlDataSource>
            <br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
            <asp:CheckBox ID="CheckBox1" runat="server" Visible="false"/>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            </asp:PlaceHolder>>
        </div>
    </form>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</body>
</html>

