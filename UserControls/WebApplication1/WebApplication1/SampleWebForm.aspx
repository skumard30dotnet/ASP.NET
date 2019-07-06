<%@ Page Title="" Language="C#" MasterPageFile="~/SampleMaster.Master" AutoEventWireup="true" CodeBehind="SampleWebForm.aspx.cs" Inherits="WebApplication1.SampleWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Age</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Click<asp:Image ID="Image1" runat="server" /></td>
            <td

                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                    <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ProductName" DataValueField="ProductID" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                    
                </asp:ListBox>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [ProductID], [ProductName] FROM [Alphabetical list of products]"></asp:SqlDataSource>
                        </ContentTemplate>
                </asp:UpdatePanel>
                <asp:Button ID="btnButton" runat="server"></asp:Button>
                
                <asp:View ID="View1" runat="server">
                   
                </asp:View>
                 <asp:Login ID="loginControl" runat="server"></asp:Login>
                <asp:Table ID="Table1" runat="server">
                    <asp:TableRow>
                        <asp:TableCell>

                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </td>
        </tr>
    </table>
</asp:Content>
