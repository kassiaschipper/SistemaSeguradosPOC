<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="SistemaSeguradosPOC.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cadastro de Segurados</h1>

<asp:Label runat="server" Text="Nome" />
<br />
<asp:TextBox ID="txtNome" runat="server" />
<br /><br />

<asp:Label runat="server" Text="CPF" />
<br />
<asp:TextBox ID="txtCpf" runat="server" MaxLength="11" />
<br /><br />

<asp:Label runat="server" Text="Email" />
<br />
<asp:TextBox ID="txtEmail" runat="server" TextMode="Email" />
<br /><br />

<asp:Label runat="server" Text="Data de nascimento" />
<br />
<asp:TextBox ID="txtDataNascimento" runat="server" TextMode="Date" />
<br /><br />

<asp:Label runat="server" Text="Valor contribuição" />
<br />
<asp:TextBox ID="txtValorContribuicao" runat="server" />
<br /><br />

<asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
<br /><br />

<asp:Label ID="lblMensagem" runat="server" />

<asp:Label runat="server" Text="Exclua o CPF:" />
<br />
<asp:TextBox ID="TextCpfExcluido" runat="server" />
<br /><br />

<asp:Button ID="btnExcluir" runat="server" Text="Excluir Segurado" OnClick="btnExcluir_Click"/>
</asp:Content>
