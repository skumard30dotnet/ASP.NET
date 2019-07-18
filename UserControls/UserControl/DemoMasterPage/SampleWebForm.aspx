<%@ Page Title="" Language="C#" MasterPageFile="~/Sample.Master" AutoEventWireup="true" CodeBehind="SampleWebForm.aspx.cs" Inherits="DemoMasterPage.SampleWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</asp:Content>
