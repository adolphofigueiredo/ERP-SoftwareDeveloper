<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="CheckConnection.aspx.cs"
    Inherits="CheckConnection" Title="Check connection"
    MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>check connection work</div>
    <asp:Label ID="lblConnectionString" AssociatedControlID="txtConnectionString" runat="server" Text="Connection string:"></asp:Label>
    <asp:TextBox ID="txtConnectionString" runat="server"></asp:TextBox>
    <asp:Button ID="btnCheckConnection" runat="server" Text="Check" OnClick="btnCheckConnection_Click" />
    <asp:Label ID="lblRisultato" runat="server" Text=""></asp:Label>
</asp:Content>

