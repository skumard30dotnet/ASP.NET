<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoASPDotNet.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" Text="Please Enter Name" runat="server"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" BorderColor="YellowGreen" BorderWidth="1px" Font-Bold="True" Font-Italic="True" Font-Size="Larger" Font-Underline="True" MaxLength="12"></asp:TextBox>
            <input type="text" id="sdf" />

            <table>
                <tr>
                    <td>
                        Id
                    </td>
                    <td>
                        Name
                    </td>
                    <td>
                        Age
                    </td>
                </tr>
                <tr>
                    <td>
                        1
                    </td>
                    <td>
                        Mahesh
                    </td>
                    <td>
                        22
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</body>
</html>

