<%@ Page Title="Lista Studenti" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="StudentiList.aspx.cs" Inherits="StudentiList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div>
    
        <asp:Label ID="lblNominativo" AssociatedControlID="txtNominativo" runat="server" Text="Nominativo"></asp:Label>
        <asp:TextBox ID="txtNominativo" runat="server"></asp:TextBox>
        <asp:Label ID="lblDataDiNascitaDa" AssociatedControlID="calDataDiNascitaDa" runat="server" Text="Data di nascita da: "></asp:Label>
        <asp:Calendar ID="calDataDiNascitaDa" runat="server"></asp:Calendar>
        <asp:Label ID="lblDataDiNascitaA" AssociatedControlID="calDataDiNascitaA" runat="server" Text="Data di nascita a: "></asp:Label>
        <asp:Calendar ID="calDataDiNascitaA" runat="server"></asp:Calendar>

        <asp:Button ID="btnRicerca" runat="server" Text="Ricerca" OnClick="btnRicerca_Click" />

    </div>
    
        <div>
            
            <asp:GridView ID="grdRisultati" runat="server">
            <columns>

                <asp:TemplateField HeaderText="Hyperlink">
                    <ItemTemplate>
                        <asp:HyperLink ID="HyperLink1" runat="server"
                            NavigateUrl="~/EditStudente.aspx"
                            Text='edit'>
                        </asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
             </columns>
        </asp:GridView>
    </div>

</asp:Content>

