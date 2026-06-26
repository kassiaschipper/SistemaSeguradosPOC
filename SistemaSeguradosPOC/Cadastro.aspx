<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="SistemaSeguradosPOC.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cadastro de Segurados</h1>

    <asp:Button ID="btnTestarConexao" runat="server" Text="Testar conexao com banco" OnClick="btnTestarConexao_Click" />
    <br />
    <br />
    <asp:Label ID="lblResultadoConexao" runat="server" />
</asp:Content>
