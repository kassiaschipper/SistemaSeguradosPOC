<%@ Page Title="Verificacao" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Verificacao.aspx.cs" Inherits="SistemaSeguradosPOC.Verificacao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Verificação de Conexão</h1>

<asp:Button ID="btnTestarConexao" runat="server" Text="Testar conexao com banco" OnClick="btnTestarConexao_Click" />
    <br />
    <br />
<asp:Label ID="lblResultadoConexao" runat="server" />

</asp:Content>
