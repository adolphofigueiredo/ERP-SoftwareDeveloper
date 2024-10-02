<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CorsiList.aspx.cs" Inherits="CorsiList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
        
        <asp:Label ID="lblNominativoCorso" AssociatedControlID="txtNominativoCorso" runat="server" Text="Corso"></asp:Label>
        <asp:TextBox ID="txtNominativoCorso" runat="server"></asp:TextBox>
        <asp:Label ID="lblInizioCorsoDa" AssociatedControlID="calInizioCorsoDa" runat="server" Text="Data di inizio di corso da: "></asp:Label>
        <asp:Calendar ID="calInizioCorsoDa" runat="server"></asp:Calendar>
        <asp:Label ID="lblInizioCorsoA" AssociatedControlID="calInizioCorsoA" runat="server" Text="Data di inizio di corso a: "></asp:Label>
        <asp:Calendar ID="calInizioCorsoA" runat="server"></asp:Calendar>
        <asp:Label ID="lblFineCorsoDa" AssociatedControlID="calFineCorsoDa" runat="server" Text="Data di fine di corso da: "></asp:Label>
        <asp:Calendar ID="calFineCorsoDa" runat="server"></asp:Calendar>
        <asp:Label ID="lblFineCorsoA" AssociatedControlID="calFineCorsoA" runat="server" Text="Data di fine di corso a: "></asp:Label>
        <asp:Calendar ID="calFineCorsoA" runat="server"></asp:Calendar>
        
        <asp:Button ID="btnRicerca" runat="server" Text="Search" OnClick ="btnRicerca_Click" />

    </div>

    <div>

        <asp:GridView ID="grdRisultati" runat="server"></asp:GridView>

    </div>

</asp:Content>

