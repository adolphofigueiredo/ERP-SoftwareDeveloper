<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditStudente.aspx.cs" Inherits="EditStudente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:HiddenField ID="hddId" runat="server" />
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
    <asp:TextBox ID="txtCf" runat="server"></asp:TextBox>
    <asp:Calendar ID="calDdn" runat="server"></asp:Calendar>
    <asp:DropDownList ID="ddlCorso" runat="server"></asp:DropDownList>
    <asp:Button ID="btnSalva" runat="server" Text="Salva" />
</asp:Content>

