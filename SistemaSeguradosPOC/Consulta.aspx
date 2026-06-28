<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="SistemaSeguradosPOC.Consulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Consulta de Segurados</h1>
     <h3>Consulte aqui a lista de Segurados Cadastrados no Sistema</h3>
<asp:Button ID="btnConsultar" runat="server" Text="Listar Segurados" OnClick="btnConsultar_Click" />
    <br /><br />
    <asp:Label ID="lblMensagem" runat="server" />
 <asp:GridView ID="gvSegurados" runat="server" AutoGenerateColumns ="false">
     <Columns>
        <asp:BoundField DataField="Nome" HeaderText="Nome" />
        <asp:BoundField DataField="Cpf" HeaderText="CPF" />
        <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:BoundField DataField="DataNascimento" HeaderText="Data de Nascimento" />
        <asp:BoundField DataField="ValorContribuicao" HeaderText="Valor da Contribuição" />

     </Columns>
  </asp:GridView>
</asp:Content>

