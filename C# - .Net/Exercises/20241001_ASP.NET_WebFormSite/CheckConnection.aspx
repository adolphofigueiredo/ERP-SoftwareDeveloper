<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckConnection.aspx.cs" Inherits="CheckConnection" Title="CheckConnection"  MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div>Check Connection Works</div>
    <asp:Label ID="lblConnectionString" AssociatedControlID="txtConnectionString" runat="server" Text="Connection String"></asp:Label>
    <asp:TextBox ID="txtConnectionString" runat="server"></asp:TextBox>
    <asp:Button ID="btnCheckConnection" runat="server" Text="Check" OnClick="btnCheckedConnection_Click" />
    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
</asp:Content>