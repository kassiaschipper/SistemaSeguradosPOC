using System;
using SistemaSeguradosPOC.Models;
using SistemaSeguradosPOC.Service;
using SistemaSeguradosPOC.Repository;

namespace SistemaSeguradosPOC
{
    public partial class Cadastro : System.Web.UI.Page
    {
        //private readonly SeguradoService _service = new SeguradoService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                var repository = new SeguradoRepository();
                var conectou = repository.TestarConexao();

                lblResultadoConexao.Text = conectou
                    ? "Conexao com o banco realizada com sucesso."
                    : "Nao foi possivel abrir a conexao com o banco.";
            }
            catch (Exception ex)
            {
                lblResultadoConexao.Text = "Erro ao conectar: " + ex.Message;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var segurado = new Segurado
                {
                    Nome = txtNome.Text.Trim(),
                    Cpf = txtCpf.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DataNascimento = DateTime.Parse(txtDataNascimento.Text),
                    ValorContribuicao = decimal.Parse(txtValorContribuicao.Text)
                };

                var service = new SeguradoService();
                service.CadastrarSegurado(segurado);

                lblMensagem.Text = "Segurado cadastrado com sucesso.";
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Erro ao cadastrar: " + ex.Message;
            }
        }
    }
}
